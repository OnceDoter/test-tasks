import React from "react";
import {TreeNode} from "../models/Tree";
import ExpandMoreIcon from "@material-ui/icons/ExpandMore";
import ChevronRightIcon from "@material-ui/icons/ChevronRight";
import {TreeItem, TreeView} from "@material-ui/lab";
import {createStyles, makeStyles, Theme} from "@material-ui/core/styles";


interface Props {
    visible: boolean,
    type: boolean,
    tree: TreeNode | undefined,
    onSelect: any,
}

class Tree extends React.Component<Props, any> {
    tree: TreeNode | undefined;
    constructor(props: Props) {
        super(props);
        this.tree = props.tree;
        this.state = {
            expanded: [''],
            selected: [''],
            classes: makeStyles((theme: Theme) =>
                createStyles({
                    root: {
                        height: 110,
                        flexGrow: 1,
                        maxWidth: 400,
                    }
                }),
            )
        }
    }

    render() {
        const handleToggle = (event: React.ChangeEvent<{}>, nodeIds: string[]) => { this.setState({expanded: [nodeIds]}); };
        const handleSelect = (event: React.ChangeEvent<{}>, nodeIds: string[]) => {
            this.setState({selected: [nodeIds]});
            if (this.props.type) this.props.onSelect([nodeIds]);
        };

        let renderTree = (node: TreeNode) => (<>
            <TreeItem key={node.id} nodeId={node.id.toString()} label={
                (this.props.visible)?
                    (node.customVal === undefined) ?
                        // TO-DO normal method:/
                        (node.val === 'Node №0') ? 'root' : node.val.replace('№0.', '№') :
                        node.customVal: ' '}>
                {Array.isArray(node.child) ? node.child.map((next) => renderTree(next)) : null}
            </TreeItem>
        </>);
        return this.props.visible?
            (<TreeView
            className={this.state.classes.root}
            defaultCollapseIcon={<ExpandMoreIcon/>}
            defaultExpanded={['root']}
            defaultExpandIcon={<ChevronRightIcon/>}
            onNodeToggle={handleToggle}
            onNodeSelect={handleSelect}
        >
            {this.tree? renderTree(this.tree) : null}
        </TreeView>):<div/>;
    }

}
export default Tree;
