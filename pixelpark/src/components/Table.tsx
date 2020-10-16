import React from "react";
import {createStyles, makeStyles, Theme} from "@material-ui/core/styles";
import {environment} from "../environment/environment";


interface Props {
    token : string
}

class Table extends React.Component<Props, any> {
    constructor(props: Props) {
        super(props);
        this.state = {
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
            ),
            error: null,
            isLoaded: false,
            requestToken: ""
        }
    }

    componentDidMount() {
        let requestTokenUrl = environment.ApiUrl + "oauth/requesttoken"
        let getRequestToken = () => {
            fetch(requestTokenUrl, {mode: 'no-cors'})
                .then(result => result.json())
                .then((data) => {this.setState({requestToken: data});},
                    (error) => {this.setState({error: error});}
                )
            console.log(this.state.requestToken)
            console.log(this.state.error)
        }
        getRequestToken()
    }


    render() {
        const { error, isLoaded, items } = this.state;
        if (error) {
            return <div>Ошибка: {error.message}</div>;
        } else if (!isLoaded) {
            return <div>Загрузка...</div>;
        } else {
            return (
                <ul>

                </ul>
            );
        }
    }
}
export default Table
