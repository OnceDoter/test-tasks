import React from 'react';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Typography from '@material-ui/core/Typography';
import {createStyles, Theme, makeStyles, createMuiTheme} from '@material-ui/core/styles';
import Contact from "./Сontact";
import {teal} from '@material-ui/core/colors';
import pink from "@material-ui/core/colors/pink";
import cyan from "@material-ui/core/colors/cyan";

const useStyles = makeStyles((theme: Theme) =>
    createStyles({
        root: {
            flexGrow: 1,
        },
        menuButton: {
            marginRight: theme.spacing(2),
        },
        title: {
            flexGrow: 1,
            display: 'none',
            [theme.breakpoints.up('sm')]: {
                display: 'block',
            },
        },
    }),
);

const theme = createMuiTheme({
    palette: {
        primary: {
            // Purple and green play nicely together.
            main: teal[500],
        },
        secondary: {
            // This is green.A700 as hex.
            main: cyan[500],
        },
    },
});

export default function Navbar() {
    const classes = useStyles();
    const navbarColor = teal[200]
    return (
        <div className={classes.root}>
            <AppBar position="static"  color="secondary">
                <Toolbar>
                    <Contact/>
                    <Typography className={classes.title} variant="h6" noWrap color="primary">
                        Coś się kończy, coś się zaczyna
                    </Typography>
                </Toolbar>
            </AppBar>
        </div>
    );
}
