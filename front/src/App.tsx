import React from 'react';
import './App.css';
import Login from './connection/Login'
import Home from "./page/Home";
import {BrowserRouter,Routes,Route } from 'react-router-dom'
import Register from "./connection/Register";


function App() {
  return (
    <div className="App">

        <BrowserRouter>
            <Routes>
                <Route path='/' element={<Home/>}/>
                <Route path='/login' element={<Login/>}/>
                <Route path='/register' element={<Register/>}/>
            </Routes>
        </BrowserRouter>
    </div>
  );
}

export default App;
