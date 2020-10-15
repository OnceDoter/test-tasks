module WebApi.Tests

open NUnit.Framework
open System.Threading.Tasks
open WebApi.Controllers.Pictures
open WebApi.Data
open Microsoft.EntityFrameworkCore
open Microsoft.Extensions.Configuration
open WebApi.Data.Models
open System.Collections

let threadsCount = 10
let testEntitiesCount = 50

let contexts = [
    for c in 0..threadsCount -> new WebApiDbContext(
                                    let builder = new DbContextOptionsBuilder<WebApiDbContext>()
                                    builder.UseSqlServer(
                                        let cfg = new ConfigurationBuilder()
                                        cfg
                                            .AddJsonFile("appsettings.json")
                                                .Build()
                                            .GetSection("ConnectionStrings")
                                            .GetSection("TestConnection").Value).Options)
]

[<SetUp>]
let Setup () = ()

let isEmpty (x:obj) =
    match x with
    | null -> true
    | :? System.Collections.IEnumerable as xs -> xs |> Seq.cast |> Seq.isEmpty
    | _ -> invalidOp <| "unsupported type " + x.GetType().FullName

[<Test>]
let PictureService_change_entities_in_10_threads_return_no_DbUpdateConcurrencyException () =
    let expected = ()
    //use best practics
    let fail (methName : string) = Assert.Fail <| "<"+methName+">" + "return null"
    //init concurrent servises
    //create test entities
    let iservices =  [for i in 0..threadsCount-1 -> new PictureService (contexts.[i])]
    
    iservices.Head.Create([|for i in 0..testEntitiesCount-1 do new Image("test descr #" + i.ToString())|]) |> ignore
    let imgs = iservices.[1].GetImages()
    let enum = imgs.GetEnumerator()
    let tasks = Array.zeroCreate threadsCount
    //simulate concurrent access
    try
    let act (service : PictureService) = 
        async{   
            for i in 0..testEntitiesCount-1 do service.Update(enum.Current) |> ignore
        }       
    let actual =
        for i in 0..threadsCount-1 do
            tasks.[i] = Task.Factory.StartNew(fun () -> act(iservices.[i])) |> ignore
        Task.WaitAll()

    Assert.AreEqual(expected, actual)