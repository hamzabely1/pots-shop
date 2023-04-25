import React from 'react';
import NavBar from "../components/NavBar";
import  "../css/home.css";

type Item = {
    name: string;
    price: number;
    description: string;
    image: string;
    type: string;
    stock: number;
}

type Items = {
    data : Item[];
}



const Home = () => {

    return (
        <div>
            <NavBar/>
            <div className="size_img">
                <img className="size_img" src="/img/imgHome.jpeg" alt="">
                </img>
                <div className="div_cree">
                </div>
            </div>
        </div>
    );
};

export default Home;