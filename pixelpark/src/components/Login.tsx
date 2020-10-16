import React from "react";
import {createStyles, makeStyles, Theme} from "@material-ui/core/styles";
import {
    Avatar,
    Button,
    Container,
    CssBaseline,
    TextField,
    Typography
} from "@material-ui/core";
import AccountTreeIcon from '@material-ui/icons/AccountTree';
import {environment} from "../environment/environment";

const useStyles = makeStyles((theme: Theme) =>
    createStyles({
        paper: {
            marginTop: theme.spacing(8),
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center',
        },
        avatar: {
            margin: theme.spacing(1),
            backgroundColor: theme.palette.secondary.main,
        },
        form: {
            width: '100%', // Fix IE 11 issue.
            marginTop: theme.spacing(1),
        },
        submit: {
            margin: theme.spacing(3, 0, 2),
        },
    }),
);

interface Props {
    onSubmit : Function
}

export default function Login(props : Props) {
    const classes = useStyles();

    let handleSubmit = () => props.onSubmit;

    return(
        <Container component="main" maxWidth="xs">
            <CssBaseline />
            <div className={classes.paper}>
                <Avatar className={classes.avatar}>
                    <AccountTreeIcon />
                </Avatar>
                <Typography component="h1" variant="h5">
                    PixelPark API
                </Typography>
                <form className={classes.form} noValidate>
                    <TextField
                        variant="outlined"
                        margin="normal"
                        required
                        fullWidth
                        label={environment.PublicKey}
                        disabled={true}
                    >
                    </TextField>
                    <TextField
                        variant="outlined"
                        margin="normal"
                        required
                        fullWidth
                        label={environment.PrivateKey}
                        disabled={true}
                    />
                    <Button
                        fullWidth
                        variant="contained"
                        color="primary"
                        className={classes.submit}
                        onClick={handleSubmit}
                    >
                        Войти
                    </Button>
                </form>
            </div>
        </Container>
    );
}
