import React from 'react';
import NavBar from "../components/NavBar";
import  "../css/home.css";
import {Route} from "react-router-dom";
import Login from "../connection/Login";

type Item = {
    name: string;
    price: number;
    description: string;
    image: string;
    type: string;
    stock: number;
}

type Items = {
    data : Item[]
}



const Home = () => {

    return (
        <div>
            <NavBar/>
            <div className="">
                <img className="size_img" src="/img/imgHome.jpeg" alt="">
                </img>
                <div className="div_cree">hamza</div>
                <div className="flex justify-center">
                    <div className="border-b-4 border-amber-800 linea mt-1">
                        <h2 className="text_nav font-bold leading-7 text-gray-900 sm:truncate sm:text-3xl sm:tracking-tight">Notre point Fort</h2>
                    </div>
                </div>
                <div className="bg-white py-24 sm:py-32">
                    <div className="mx-auto max-w-7xl px-6 lg:px-8">
                        <dl className="grid grid-cols-1 gap-x-8 gap-y-16 text-center lg:grid-cols-3">

                            <div className="mx-auto flex max-w-xs flex-col gap-y-4">
                                <dt className="text-base leading-7 text-gray-600">Quality</dt>
                                <p>Un matériau est considéré comme recyclable lorsqu'il peut être collecté, transformé et réutilisé pour la production de nouveaux matériaux ou produits. Ce processus de recyclage réduit le besoin de nouvelles ressources naturelles et l'impact environnemental associé à leur extraction et à leur production.</p>
                                <dd className="order-first text-3xl font-semibold tracking-tight text-gray-900 sm:text-5xl flex justify-center">
                                    <img src="/img/quality.png" className="logo2"></img>
                                </dd>
                            </div>

                            <div className="mx-auto flex max-w-xs flex-col gap-y-4">
                                <dt className="text-base leading-7 text-gray-600">Quality</dt>
                                <p>Un matériau est considéré comme recyclable lorsqu'il peut être collecté, transformé et réutilisé pour la production de nouveaux matériaux ou produits. Ce processus de recyclage réduit le besoin de nouvelles ressources naturelles et l'impact environnemental associé à leur extraction et à leur production.</p>
                                <dd className="order-first text-3xl font-semibold tracking-tight text-gray-900 sm:text-5xl flex justify-center">
                                    <img src="/img/quality.png" className="logo2"></img>
                                </dd>
                            </div>


                            <div className="mx-auto flex max-w-xs flex-col gap-y-4">
                                <dt className="text-base leading-7 text-gray-600">Quality</dt>
                                <p>Un matériau est considéré comme recyclable lorsqu'il peut être collecté, transformé et réutilisé pour la production de nouveaux matériaux ou produits. Ce processus de recyclage réduit le besoin de nouvelles ressources naturelles et l'impact environnemental associé à leur extraction et à leur production.</p>
                                <dd className="order-first text-3xl font-semibold tracking-tight text-gray-900 sm:text-5xl flex justify-center">
                                    <img src="/img/quality.png" className="logo2"></img>
                                </dd>
                            </div>

                        </dl>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default Home;