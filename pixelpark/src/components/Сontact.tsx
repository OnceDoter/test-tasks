import React from 'react';
import Button from '@material-ui/core/Button';
import Menu from '@material-ui/core/Menu';
import MenuItem from '@material-ui/core/MenuItem';
import InstagramIcon from '@material-ui/icons/Instagram'
import AlternateEmailIcon from '@material-ui/icons/AlternateEmail';
import GitHubIcon from '@material-ui/icons/GitHub';
import {Grid} from "@material-ui/core";
import {Link} from 'react-router-dom'
import {Router} from "@material-ui/icons";
import {environment} from "../environment/environment";

export default function Contact() {

    const [anchorEl, setAnchorEl] = React.useState<null | HTMLElement>(null);

    const handleClick = (event: React.MouseEvent<HTMLButtonElement>) => {
        setAnchorEl(event.currentTarget);
    };

    const handleClose = () => {
        setAnchorEl(null);
    };

    return (
        <div>
            <Button aria-controls="simple-menu" aria-haspopup="true" onClick={handleClick}>
                Open Menu
            </Button>
            <Menu
                id="simple-menu"
                anchorEl={anchorEl}
                keepMounted
                open={Boolean(anchorEl)}
                onClose={handleClose}
            >
                <MenuItem>
                    <Router>
                        <Link to={environment.GitHubProfile}>
                            <Button>
                                <Grid container spacing={2}>
                                    <Grid item xs>
                                        <GitHubIcon fontSize="small"/>
                                    </Grid>
                                    <Grid item>
                                        Show me in github!
                                    </Grid>
                                </Grid>
                            </Button>
                        </Link>
                    </Router>
                </MenuItem>
                <MenuItem>
                    <Router>
                        <Link to={environment.MailProfile}>
                            <Button>
                                <Grid container spacing={2}>
                                    <Grid item xs>
                                        <AlternateEmailIcon fontSize="small"/>
                                    </Grid>
                                    <Grid item>
                                        My world mail.ru
                                    </Grid>
                                </Grid>
                            </Button>
                        </Link>
                    </Router>
                </MenuItem>
                <MenuItem>
                    <Router>
                        <Link to={environment.InstagramProfile}>
                            <Button>
                                <Grid container spacing={2}>
                                    <Grid item xs>
                                        <InstagramIcon fontSize="small"/>
                                    </Grid>
                                    <Grid item>
                                        Godlike instagram
                                    </Grid>
                                </Grid>
                            </Button>
                        </Link>
                    </Router>
                </MenuItem>
            </Menu>
        </div>
    );
}
