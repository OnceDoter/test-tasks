import React from "react";
import {createStyles, makeStyles, Theme} from "@material-ui/core/styles";
import {DialogTitle} from "@material-ui/core";
import Button from "@material-ui/core/Button";
import DeleteIcon from '@material-ui/icons/Delete';
import AddIcon from '@material-ui/icons/Add';
import EditIcon from '@material-ui/icons/Edit';
import RotateLeftIcon from '@material-ui/icons/RotateLeft';
import DialogActions from "@material-ui/core/DialogActions";
import Dialog from "@material-ui/core/Dialog";
import DialogContent from "@material-ui/core/DialogContent";
import DialogContentText from "@material-ui/core/DialogContentText";
import TextField from "@material-ui/core/TextField";
import {TreeNode} from "../models/Tree";


interface Props {
    selectedNode: string | undefined;
    OnAdd: any,
    OnAddChild: any,
    OnEdit: any,
    OnDelete: any,
    OnReset: any
}

class Buttons extends React.Component<Props, any>{
    constructor(props: Props) {
        super(props);
        this.state = {
            open: false,
            name: '',
            classes: makeStyles((theme: Theme) =>
                createStyles({
                    button: {
                        margin: theme.spacing(1),
                    },
                    root: {
                        height: 110,
                        flexGrow: 1,
                        maxWidth: 400,
                    },
                }),
            )
        }
    }
    render() {
        const handleAdd = () => {
            this.props.OnAdd();
        }
        const handleAddChild = () => {
            this.props.OnAddChild();
        }
        const handleRemove = () => {
            this.props.OnDelete();
        }
        let initName: string | undefined;
        const handleClickOpen = () => {
            initName = this.props.selectedNode?.replace('№0.', '№');
            this.setState({name: initName});
            this.setState({open: true});
        }
        const handleClose = () => {
            this.setState({open: false});
            this.setState({name: initName});
            this.props.OnEdit(initName);
        }
        const handleSubmit = () => {
            this.setState({open: false});
        }
        const handleEdit = (event: React.ChangeEvent<HTMLInputElement>) => {
            this.setState({name: event.target.value});
            this.props.OnEdit(event.target.value);
        }
        const handleReset = () => {
            this.props.OnReset();
        }

        return (<div style={{margin: '100px'}}>
            <Button
                variant="contained"
                color="primary"
                className={this.state.classes.button}
                style={{margin:'5px'}}
                endIcon={<AddIcon />}
                onClick={() => { handleAdd() }}
            >
                Add
            </Button>
            <Button
                variant="contained"
                color="primary"
                className={this.state.classes.button}
                style={{margin:'5px'}}
                endIcon={<AddIcon />}
                onClick={() => { handleAddChild() }}
            >
                AddChild
            </Button>
            <Button
                variant="contained"
                color="secondary"
                className={this.state.classes.button}
                style={{margin:'5px'}}
                startIcon={<DeleteIcon />}
                onClick={() => { handleRemove() }}
            >
                Delete
            </Button>
            <Button
                variant="contained"
                color="default"
                className={this.state.classes.button}
                style={{margin:'5px'}}
                startIcon={<EditIcon />}
                onClick={() => { handleClickOpen() }}
            >
                Edit
            </Button>
            <Dialog open={this.state.open} onClose={handleClose} aria-labelledby="form-dialog-title">
                <DialogTitle id="form-dialog-title">Edit form</DialogTitle>
                <DialogContent>
                    <DialogContentText>
                        To change the Node name, enter a new name.
                    </DialogContentText>
                    <TextField
                        autoFocus
                        margin="dense"
                        id="newNodeName"
                        label="new name"
                        type="text"
                        fullWidth
                        value={this.state.name}
                        onChange={handleEdit}
                    />
                </DialogContent>
                <DialogActions>
                    <Button onClick={handleClose} color="primary">
                        Cancel
                    </Button>
                    <Button onClick={handleSubmit} color="primary">
                        Submit
                    </Button>
                </DialogActions>
            </Dialog>
            {/*<Button
                variant="contained"
                color="secondary"
                className={this.state.classes.button}
                style={{margin:'5px'}}
                startIcon={<RotateLeftIcon />}
                onClick={() => { handleReset() }}
            >
                Reset
            </Button>*/}

        </div>);
    }
}
export default Buttons;
