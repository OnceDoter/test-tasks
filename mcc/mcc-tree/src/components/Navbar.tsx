import React from "react";
import {AppBar} from "@material-ui/core";
import Toolbar from "@material-ui/core/Toolbar";

export const Navbar: React.FunctionComponent = () => (
    <AppBar position="static">
        <Toolbar>
            <text>Not simple node tree</text>
        </Toolbar>
    </AppBar>
)
