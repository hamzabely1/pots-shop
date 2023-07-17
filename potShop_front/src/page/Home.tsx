import React, {useEffect, useState} from 'react';
import NavBar from "../components/NavBar";
import  "../css/home.css";
import {Route} from "react-router-dom";
import Login from "../connection/Login";
import PointFort from "./PointFort";
import Item from "./Item";
import axios from "axios";


const Home = () => {



    return (
        <div>
            <NavBar/>
                <div className="">
                    <div className="bg-white">
                        <div className="py-15 xl:px-10">
                            <div
                                className="relative isolate overflow-hidden bg-amber-600 px-8 pt-16 shadow-2xl sm:rounded-3xl sm:px-20 md:pt-50 lg:flex lg:gap-x-20 lg:px-24 lg:pt-0">
                                <svg viewBox="0 0 1024 1024"
                                     className="absolute left-1/2 top-1/2 -z-10 h-[64rem] w-[64rem] -translate-y-1/2 [mask-image:radial-gradient(closest-side,white,transparent)] sm:left-full sm:-ml-80 lg:left-1/2 lg:ml-0 lg:-translate-x-1/2 lg:translate-y-0"
                                     aria-hidden="true">
                                    <circle cx="512" cy="512" r="512" fill="url(#759c1415-0410-454c-8f7c-9a820de03641)"
                                            fillOpacity="0.7"/>
                                    <defs>
                                        <radialGradient id="">
                                            <stop stopColor="#7775D6"/>
                                            <stop offset="1" stopColor="#E935C1"/>
                                        </radialGradient>
                                    </defs>
                                </svg>
                                <div
                                    className="mx-auto max-w-md text-center lg:mx-0 lg:flex-auto lg:py-32 lg:text-left">
                                    <h2 className="text-3xl font-bold tracking-tight text-white sm:text-4xl">Cree ton vase maintenate.<br/>avec les 1000 posiibilite</h2>
                                    <p className="mt-6 text-lg leading-8 text-gray-300"></p>
                                    <div className="mt-10 flex items-center justify-center gap-x-6 lg:justify-start">
                                        <a href="#"
                                           className="rounded-md bg-white px-3.5 py-2.5 text-sm font-semibold text-gray-900 shadow-sm hover:bg-gray-100 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-white">commencer</a>
                                        <a href="#" className="text-sm font-semibold leading-6 text-white">Learn
                                            more <span aria-hidden="true">→</span></a>
                                    </div>
                                </div>
                                <div className="relative mt-16 h-80 xl:mt-10  flex">
                                    <div className="flex w-50 bg-amber-900">
                                       <img
                                        className="m-10 -rotate-41"
                                        src="/img/imgHome2.png"
                                        alt="App screenshot" width="" height=""/>
                                        <div>

                                            <img
                                                className="m-10 -rotate-41"
                                                src="/img/imgHome2.png"
                                                alt="App screenshot" width="" height=""/>
                                        </div>
                                        <img
                                            className="m-10 -rotate-41"
                                            src="/img/imgHome2.png"
                                            alt="App screenshot" width="" height=""/>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>

                 <PointFort/>
                <Item/>

            </div>
        </div>
    );
};

export default Home;