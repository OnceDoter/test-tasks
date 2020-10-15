import React, {useState} from "react";
import {createStyles, makeStyles, Theme} from "@material-ui/core/styles";
import {TreeNode} from "../models/Tree";
import Tree from "./Tree";
import Buttons from "./Buttons";

const useStyles = makeStyles((theme: Theme) =>
    createStyles({
        button: {
            marginTop: '50px',

        },
        root: {
            flexGrow: 1,
        },
        container: {
            margin: '50px',
            padding: theme.spacing(2),
            textAlign: 'center',
            color: theme.palette.text.secondary,
        },
    }),
);

function AppView() {
    const classes = useStyles();
    const [tree, setTree] = useState<TreeNode>(new TreeNode(true));
    const [selected, setSelected] = useState<Array<string>>([]);
    let handleOnSelect = (id: string[]) =>{
        setSelected((selected) => id);
    };
    let handleAdd = () => {
        let nodeId = tree.getById(selected.toString())?.Add().id;
        let newTree = tree.Copy();
        setTree((tree) => newTree);
    }
    let handleAddChild = () => {
        let nodeId = tree.getById(selected.toString())?.AddChild().id;
        let newTree = tree.Copy();
        setTree((tree) => newTree);
    }
    let handleEdit = (name: string) => {
        let node = tree.getById(selected.toString());
        if (node) {
            let val = node.val;
            node.customVal = name;
            let newTree = tree.Copy();
            setTree((tree) => newTree);
        }
    }
    let handleDelete = () => {
        tree.getById(selected.toString())?.Remove();
        let newTree = tree.Copy();
        setTree((tree) => newTree);
    }

    let handleReset = () => {
        let newTree = new TreeNode(true);
        setTree((tree) => newTree);
    }

    return (
        <div className={classes.root}>
            <Tree tree={tree} visible={true} type={true} onSelect={handleOnSelect}/>
            <Buttons
                selectedNode={tree.getById(selected.toString())?.val}
                OnAdd={handleAdd}
                OnAddChild={handleAddChild}
                OnDelete={handleDelete}
                OnEdit={handleEdit}
                OnReset={handleReset}
            />
        </div>
    );
}
export default AppView
