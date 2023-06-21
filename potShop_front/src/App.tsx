import React, { useEffect, useState } from "react";
import './App.css';
import Login from './connection/Login'
import Home from "./page/Home";
import {BrowserRouter,Routes,Route } from 'react-router-dom'
import Register from "./connection/Register";
import Nous from "./page/Nous";
import Error404 from "./components/Error404";
function App() {
    return (
    <div className="App">
        <BrowserRouter>
            <Routes>
                <Route path='/' element={<Home />}/>
                <Route path='/login' element={<Login/>}/>
                <Route path='/nous' element={<Nous/>}/>
                <Route path='/register' element={<Register/>}/>
                <Route path='/*' element={<Error404/>}/>
            </Routes>
        </BrowserRouter>
    </div>
  );
}

export default App;
