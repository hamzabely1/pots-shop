import React from 'react';

const PointFort = () => {






    return (
        <div>
            <div className="relative justify-center flex items-center">
                    <div className="bg-amber-700 linea1"></div>
                    <h2 className="text_nav  leading-7 text-gray-900 sm:truncate sm:text-3xl sm:tracking-tight">Notre point fort</h2>
                    <div className="linea1"></div>
            </div>
            <div className="bg-white  sm:py-20">
                <div className="mx-auto max-w-7xl px-6 lg:px-8">
                    <dl className="grid grid-cols-1 gap-x-8 gap-y-16 text-center lg:grid-cols-3">

                        <div className="mx-auto flex max-w-xs flex-col gap-y-4">
                            <dt className="text-base leading-7 text-gray-600">Quality</dt>
                            <p>Un matériau est considéré comme recyclable lorsqu'il peut être collecté, transformé et réutilisé pour la production de nouveaux matériaux ou produits. Ce processus de recyclage réduit le besoin de nouvelles ressources naturelles </p>
                            <dd className="order-first text-3xl font-semibold tracking-tight text-gray-900 sm:text-5xl flex justify-center">
                                <img src="/img/logo2.jpg" className="logo2"></img>
                            </dd>
                        </div>

                        <div className="mx-auto flex max-w-xs flex-col gap-y-4">
                            <dt className="text-base leading-7 text-gray-600">Quality</dt>
                            <p>Un matériau est considéré comme recyclable lorsqu'il peut être collecté, transformé et réutilisé pour la production de nouveaux matériaux ou produits. Ce processus de recyclage réduit le besoin de nouvelles ressources naturelles </p>
                            <dd className="order-first text-3xl font-semibold tracking-tight text-gray-900 sm:text-5xl flex justify-center">
                                <img src="/img/quality.png" className="logo3"></img>
                            </dd>
                        </div>


                        <div className="mx-auto flex max-w-xs flex-col gap-y-4">
                            <dt className="text-base leading-7 text-gray-600">Quality</dt>
                            <p>Un matériau est considéré comme recyclable lorsqu'il peut être collecté, transformé et réutilisé pour la production de nouveaux matériaux ou produits. Ce processus de recyclage réduit le besoin de nouvelles ressources naturelles </p>
                            <dd className="order-first text-3xl font-semibold tracking-tight text-gray-900 sm:text-5xl flex justify-center">
                                <img src="/img/logo3.png" className="logo1"></img>
                            </dd>
                        </div>

                    </dl>
                </div>
            </div>
        </div>
    );
};

export default PointFort;