import React from 'react';
import '../css/navBar.css'
const NavBar = ({}) => {
    return (
        <div>
            <nav className="">
                <div className="m-2 font-bold">
                    <div className="relative flex h-16 items-center justify-between">

                        <div className="flex flex-shrink-0 items-center">
                            <img className="logo" src="/img/logos.PNG" alt="img"></img>
                        </div>

                        <div className="flex flex-1 items-center justify-center sm:items-stretch sm:justify-start">

                            <div className="hidden sm:ml-6 sm:block">
                                <div className="flex space-x-8">
                                    <a href="/"
                                       className="text_nav rounded-md px-3 py-2 text-sm font-medium"
                                       aria-current="page">HOME</a>
                                    <a href="#"
                                       className="bold text_nav rounded-md px-3 py-2 text-sm font-medium">COLLECTION</a>
                                    <a href="#"
                                       className="text_nav rounded-md px-3 py-2 text-sm font-medium">FORUM</a>
                                    <a href="#"
                                       className="text_nav rounded-md px-3 py-2 text-sm font-medium">CONTACT</a>
                                    <a href="#"
                                       className="rounded-md px-3 py-2 text-sm font-medium text_nav">PLUS SUR LES VASE</a>
                                </div>
                            </div>
                        </div>
                                <a href="/register"
                                className="rounded-md px-3 py-2 text-sm font-medium text_nav_connection">REGISTER</a>
                            <a href="/login"
                            className=" rounded-md px-3 py-2 text-sm font-medium text_nav_connection">LOGIN</a>
                    </div>
                </div>
            </nav>
            
        </div>
    );
};

export default NavBar;