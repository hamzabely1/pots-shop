import React, {useEffect, useState} from 'react';
import axios from "axios";


interface ItemClass {
    itemName: string;
    itemImage : string;
    itemPrice : number;
}

const Item = () => {

    const [dataItem,setDataItem] = useState([])

    useEffect(() => {

        axios.get("https://localhost:7269/api/Item").then((res) => {
            const all = res.data;
            console.log(all)
            setDataItem(all);
        });
    },[]);

    return (
        <div>
            <div className="relative justify-center flex items-center">
                <div className="bg-amber-700 linea1"></div>
                <h2 className="text_nav  leading-7 text-gray-900 sm:truncate sm:text-3xl sm:tracking-tight">Notre Produits</h2>
                <div className="linea1"></div>
            </div>

<div className=" flex">
                {
                   dataItem.map((value : ItemClass,i) => (
            <div className="bg-white">
                <div className="sm:py-24">

                    <div className="card flex justify-center">
                        <a href="#" className="">
                            <p className="mt-1 text-lg font-medium text-gray-900 m-5 ">{value.itemName}</p>
                            <div
                                className="w-52 flex justify-center">
                                <img
                                    src={value.itemImage}
                                    alt="Tall slender porcelain bottle with natural clay textured body and cork stopper."
                                    className="h-full w-full object-cover object-center group-hover:opacity-75"/>
                            </div>
                            <button
                                className="rounded-md bg-red-50 px-2 py-1 text-xl font-medium text-red-700 ring-1 ring-inset ring-red-600/10">info</button>
                            <h3 className="mt-4 text-sm text-gray-700">{value.itemPrice} $</h3>

                            <button
                                className="rounded-md bg-red-50 px-2 py-1 text-xl font-medium text-red-700 ring-1 ring-inset ring-red-600/10">ajoute au panier</button>
                        </a>
                    </div>
                </div>

            </div>
                    ))
                }
</div>
        </div>
    );
};

export default Item;