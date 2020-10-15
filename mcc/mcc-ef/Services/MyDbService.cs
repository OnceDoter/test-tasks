using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ef
{
    class MyDbService
    {
        public MyDbService()
        {
            using var context = new MyDbContext();
            context.Database.Migrate();
            InitDb(context);
            var selection = Select(context);
            Console.WriteLine("If the comment number = 9, then everything is correct");
            foreach (var strTuple in selection)
            {
                Console.WriteLine($"{strTuple.Item1} --last comment-->{strTuple.Item2.Text}({strTuple.Item2.CreatedDateTime})");
            }
            Console.Read();

        }


        //Old method, does not work with sqlite, possibly due to joins
        IEnumerable<Tuple<string, PostComments>> Select(MyDbContext context)
            => context.Posts
                .GroupJoin(context.Comments,
                    p => p.Id,
                    c => c.PostId,
                    (p, c) => new
                    {
                        PostId = p.Id,
                        Post = p.PostText,
                        Comments = c
                    })
                .Select(u => new
                {
                    Post = u.Post,
                    Comment = u.Comments.FirstOrDefault(c
                        => c.CreatedDateTime >= u.Comments.Max(t => t.CreatedDateTime))
                })
                .OrderBy(u => u.Comment.CreatedDateTime)
                .AsEnumerable()
                .Select(u => new Tuple<string, PostComments>
                    (
                        u.Post,
                        u.Comment)
                );

        //Generation of values in the db
        void InitDb(MyDbContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                var post = new Post()
                {

                    Id = i+1000,
                    PostText = $"Generated post №{i}",
                    CreateDateTime = DateTime.Now
                };

                context.Posts.Add(post);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var comment = new PostComments()
                    {
                        Text = $"Generated comment №{j}",
                        PostId = i+1000,
                        CreatedDateTime = DateTime.Now
                    };
                    context.Comments.Add(comment);
                    Thread.Sleep(15); //Otherwise, the DateTime.Now will be the same
                }
            }
            Thread.Sleep(200);
            context.SaveChanges();
        }
    }
}
