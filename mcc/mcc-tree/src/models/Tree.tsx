export class TreeNode{
    get val(): string {
        if (!this.edited){
            return this.getVal();
        } else {
            return this._val;
        }
    }
    set val(value: string) {
        this._val = value;
    }
    id: string;
    prev: TreeNode | undefined;
    next: TreeNode | undefined;
    parent: TreeNode | undefined;
    child: TreeNode[] | undefined;
    // @ts-ignore
    private _val: string;
    customVal: string | undefined;
    private edited: boolean = false;

    constructor(init: boolean = false) {
        this.id = Math.random().toString(36).substr(2, 9);
        if (init) this.initSrcTree()
    }

    public Copy(): TreeNode{
        let result = new TreeNode();
        result.customVal = this.customVal;
        if (Array.isArray(this.child)) result.child = this.child;
        if (this.next) result.next = this.next;
        if (this.prev) result.prev = this.prev;
        if (this.parent) result.parent = this.parent;
        return result;
    }
    public initSrcTree(): TreeNode{
        return this
            .AddChild()
            .Add()
            .Add()
            .AddChild()
            .Add()
            .AddChild()
            .parent?.parent?.Add() as TreeNode
    }
    public getById(id: string):TreeNode|undefined{
        let result;
        if (id.toString().localeCompare(this.id) === 0){
            result = this;
        } else {
            if (Array.isArray(this.child)) {
                for (let child of this.child){
                    let getted = child.getById(id);
                    if (getted) result = getted;
                }
            } else {
                result = this.next?.getById(id);
            }
        }
        return result;
    }


    public Add(): TreeNode{
        let node = new TreeNode();
        node.parent = this.parent;
        node.prev = this;
        node.next = this.next;
        this.next = node;
        if (this.parent !== undefined){
            let child = this.parent.child;
            let fs;
            if (Array.isArray(child)) {
                fs = child?.splice(0, child.indexOf(this) + 1);
                if (Array.isArray(fs)) {
                    fs.push(node);
                    fs.push.apply(fs, child);
                }
            }
            this.parent.child = fs
        }
        return this.next;
    }
    public AddChild(): TreeNode{
        let node = new TreeNode();
        node.parent = this;
        this.child = [node];
        return this.child[this.child.length - 1];
    }
    getVal(): string{
        this._val = 'Node №';
        let prev = this.prev?.val.split('.')
        let s;
        if (prev) s = prev[prev?.length - 1]
        if(this.parent){
            this._val += this.parent.val.split('Node №');
            this._val += '.';
            this._val += (s)? String(Number(s) + 1): '0';
        } else {
            this._val += '0'
        }
        return this._val.replace(',','');
    }
    public Remove(){
        if (this.parent){
            if (Array.isArray(this.parent.child)){
                let index = this.parent.child.indexOf(this);
                if (index){
                    this.parent.child.splice(index,1);
                }
            }
        }
    }
}




