import React, { useEffect, useState } from "react";
import './App.css';
import Login from './connection/Login'
import Home from "./page/Home";
import {BrowserRouter,Routes,Route } from 'react-router-dom'
import Register from "./connection/Register";
import Nous from "./page/Nous";




//const data = [{name: 'hamza',message: 'hello'},{name: 'hamza',message: 'bely'}]


function App() {
    return (
    <div className="App">
        <BrowserRouter>
            <Routes>
                <Route path='/' element={<Home />}/>
                <Route path='/login' element={<Login/>}/>
                <Route path='/register' element={<Register/>}/>
                <Route path='/nous' element={<Nous/>}/>

            </Routes>
        </BrowserRouter>
    </div>
  );
}

export default App;
