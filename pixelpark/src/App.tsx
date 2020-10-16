import React, {useState} from 'react';
import './App.css';
import {Container, Typography} from "@material-ui/core";
import Navbar from "./components/Navbar";
import Login from "./components/Login";
import Table from "./components/Table";

function App() {
    const [loginFormVisible, setLoginFormVisible] = useState(true);
    let onLogin = () => setLoginFormVisible(false);

    if (loginFormVisible) return (
        <div className="App">
            <Navbar/>
            <Login onSubmit={onLogin}/>
        </div>
    ); else return (
        <div className="App">
            <Navbar/>
            <Table token={'ds'}/>
        </div>
    );
}

export default App;
