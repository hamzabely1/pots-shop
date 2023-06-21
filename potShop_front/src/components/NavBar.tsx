import React, {useState} from 'react';
import '../css/navBar.css'
import { Link } from "react-router-dom";
import Home from "../page/Home";
import { RiCloseLine } from "react-icons/ri";
import Register from "../connection/Register";


const NavBar :  React.FC  = () => {
    const [modalOpen, setModalOpen] = useState(false);


    const handleOpenModal = () => {
        setModalOpen(true);
    };

    const handleCloseModal = () => {
        setModalOpen(false);
    };


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
                                    <Link to={"/"}
                                       className="text_nav rounded-md px-3 py-2 text-sm font-medium"
                                       aria-current="page">HOME</Link>
                                    <Link to={"/collection"}
                                       className="bold text_nav rounded-md px-3 py-2 text-sm font-medium">COLLECTION</Link>
                                    <Link to={"/forum"}
                                       className="text_nav rounded-md px-3 py-2 text-sm font-medium">FORUM</Link>
                                    <Link to={"/contact"}
                                       className="text_nav rounded-md px-3 py-2 text-sm font-medium">CONTACT</Link>
                                    <Link to={"/nous"}
                                       className="rounded-md px-3 py-2 text-sm font-medium text_nav">PLUS SUR LES VASE</Link>
                                </div>
                            </div>
                        </div>

                        <Link to={"/register"} className=" rounded-md pt-4 px-1 py-2 text-sm font-medium text_nav_connection">REGISTER</Link>
                        <Link to={"/login"} className=" rounded-md pt-4 px-3 py-2 text-sm font-medium text_nav_connection">LOGIN</Link>
                    </div>

                </div>
            </nav>

        </div>
    );
};

export default NavBar;