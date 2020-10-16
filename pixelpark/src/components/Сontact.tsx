import React from 'react';
import Button from '@material-ui/core/Button';
import Menu from '@material-ui/core/Menu';
import MenuItem from '@material-ui/core/MenuItem';
import InstagramIcon from '@material-ui/icons/Instagram'
import AlternateEmailIcon from '@material-ui/icons/AlternateEmail';
import GitHubIcon from '@material-ui/icons/GitHub';
import {Grid} from "@material-ui/core";
import {environment} from "../environment/environment";

export default function Contact() {
    const onClick = (ref : string) => window.location.href = ref

    return (
        <div>
            <Menu
                id="simple-menu"
                keepMounted
                open={true}
            >
                <MenuItem>
                    <Button onClick={()=>onClick(environment.GitHubProfile)}>
                        <Grid container spacing={2}>
                            <Grid item xs>
                                <GitHubIcon fontSize="small"/>
                            </Grid>
                            <Grid item>
                                Show me in github!
                            </Grid>
                        </Grid>
                    </Button>
                </MenuItem>
                <MenuItem>
                    <Button onClick={()=>onClick(environment.MailProfile)}>
                        <Grid container spacing={2}>
                            <Grid item xs>
                                <AlternateEmailIcon fontSize="small"/>
                            </Grid>
                            <Grid item>
                                My world mail.ru
                            </Grid>
                        </Grid>
                    </Button>
                </MenuItem>
                <MenuItem>
                    <Button onClick={()=>onClick(environment.InstagramProfile)}>
                        <Grid container spacing={2}>
                            <Grid item xs>
                                <InstagramIcon fontSize="small"/>
                            </Grid>
                            <Grid item>
                                Godlike instagram
                            </Grid>
                        </Grid>
                    </Button>
                </MenuItem>
            </Menu>
        </div>
    );
}
