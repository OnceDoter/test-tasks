import React from "react";
import {createStyles, makeStyles, Theme} from "@material-ui/core/styles";


interface Props {
    token : string
}

class Table extends React.Component<Props, any> {
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
        return undefined;
    }
}
export default Table
