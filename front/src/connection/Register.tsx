import React from 'react';
import Heder from "../components/Heder";
import NavBar from "../components/NavBar";

const Register = () => {
    return (
        <div>
            <NavBar/>
            <div className="flex justify-between container_login">
                <div className="flex min-h-full flex-col justify-center px-6 py-12 lg:px-8 ml-72 mb-[190px]">
                    <div className="sm:mx-auto sm:w-full sm:max-w-sm">
                        <h2 className="mt-10 text-center text-2xl font-bold leading-9 tracking-tight text-gray-900">Inscription</h2>
                    </div>
                    <div className="mt-10 sm:mx-auto sm:w-full sm:max-w-sm">
                        <form className="space-y-6" action="#" method="POST">
                            <div>
                                <label htmlFor="email" className="block text-sm font-medium leading-6 text-gray-900">Nom</label>
                                <div className="mt-2">
                                    <input id="email" name="email" type="email" autoComplete="email" required
                                           className="block w-full rounded-md border-0 py-1.5 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"/>
                                </div>
                            </div>

                            <div>
                                <label htmlFor="email" className="block text-sm font-medium leading-6 text-gray-900">Prenom</label>
                                <div className="mt-2">
                                    <input id="email" name="email" type="email" autoComplete="email" required
                                           className="block w-full rounded-md border-0 py-1.5 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"/>
                                </div>
                            </div>


                            <div>
                                <label htmlFor="email" className="block text-sm font-medium leading-6 text-gray-900">Email
                                    address</label>
                                <div className="mt-2">
                                    <input id="email" name="email" type="email" autoComplete="email" required
                                           className="block w-full rounded-md border-0 py-1.5 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"/>
                                </div>
                            </div>

                            <div>
                                <div className="flex items-center justify-between">
                                    <label htmlFor="password"
                                           className="block text-sm font-medium leading-6 text-gray-900">Password</label>
                                    <div className="text-sm">
                                        <a href="#" className="font-semibold text-indigo-600 hover:text-indigo-500">Forgot
                                            password?</a>
                                    </div>
                                </div>
                                <div className="mt-2">
                                    <input id="password" name="password" type="password" autoComplete="current-password"
                                           required
                                           className="block w-full rounded-md border-0 py-1.5 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"/>
                                </div>
                            </div>

                            <div>
                                <button type="submit"
                                        className="flex w-full justify-center rounded-md bg-indigo-600 px-3 py-1.5 text-sm font-semibold leading-6 text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600">Sign
                                    in
                                </button>
                            </div>
                        </form>

                        <p className="mt-10 text-center text-sm text-gray-500">
                            Not a member?
                            <a href="#" className="font-semibold leading-6 text-indigo-600 hover:text-indigo-500">Start a 14
                                day free trial</a>
                        </p>
                    </div>

                </div>
                <div className="">
                    <img className="size_img" src="https://s3-alpha-sig.figma.com/img/231c/4663/2b7bc0a6298aafb8e8f6a159743acd96?Expires=1683504000&Signature=msREY6lxnwjPDW~fBOnJ1N-CnKWDcQtOC1mXuaqSitfI-zYmbeR16U9MiGUoAPfvvy4vNKvo1pVYuiSHbM9eYB5gww4hmw~zPkriw2FsVita5X-LI7GdQNYOA8lcqXJOwVYlNRbL0I55TWnCYF1nHg~Zg0IUVBN5-Ehf8k5lu66BXHmWE2~TIxu29DoI4qSmtX64S0Iwit4od-7~XmpD9mR4cI-gYcrk0KVY4-RE5Qjyl0MwiJn7jOQ0c9MkQwKEcPosr0ZRQNi4St~z3DRGqmkOMsP080lu-IxpxMLtldxR0fkI2DV1jFIGUbhyBYwWPjBgM3M5XaVVeYYA905-kg__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4" alt=""></img>
                </div>
            </div>
        </div>
    );
};

export default Register;