import React, {useEffect, useState} from 'react';
import {useGetData} from "../service/useGetData";



interface ItemClass {
    image: string;
    name : string;
    price : number;
    stock : number;
    category : number;
    color : number;
    material : number;
    createdDate : string;
    updateDate : string;
    description : string;
}
const  Item : React.FC = () => {

    let data = useGetData('Item')

    return (
        <div>

            <div className="relative justify-center flex items-center">
                <div className="bg-amber-700 linea1"></div>
                <h2 className="text_nav leading-7 text-gray-900 sm:truncate sm:text-3xl sm:tracking-tight">Notre
                    Produits</h2>
                <div className="linea1"></div>
            </div>

            <div className="container">
                <div className="row flex justify-center">
                {
                    data.map((item : ItemClass,index) => (
                    <div className="cards col-md-3  flex flex-col" key={index}>
                    <div className="w-100">
                    <img src={item.image} className="" alt=""/>
                    </div>

                    <p className="mt-1">{item.name}</p>
                        <div className="relative cursor-pointer gap-4 flex justify-center">
                            <div
                                className="w-8 h-8 bg-[#f6cda8] transition-all rounded-full block ring-[#f6cda8] hover:ring-2 ring-offset-1 "></div>
                            <div
                                className="w-8 h-8 bg-[#d89d94] transition-all rounded-full block ring-[#d89d94] hover:ring-2 ring-offset-1 "></div>
                            <div
                                className="w-8 h-8 bg-[#dd6b6c] transition-all rounded-full block ring-[#dd6b6c] hover:ring-2 ring-offset-1 "></div>
                            <div
                                className="w-8 h-8 bg-[#875d71] transition-all rounded-full block ring-[#875d71] hover:ring-2 ring-offset-1 "></div>
                        </div>


                    <p className="mt-1">{item.price} €</p>
                            </div>
                    ))
                }
                </div>
            </div>
        </div>
    );
};

export default Item;