import React, { useState} from 'react';
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import  "../css/home.css";
import {RegisterService} from "../service/RegisterService";
import NavBar from "../components/NavBar";
import {ToastError, ToastSuccess} from "../PoPup/Toast";



const Register: React.FC = () => {
    const [firstName,setFirstName] = useState<string>("")
    const [lastName,setLastName] = useState<string>("")
    const [email, setEmail] = useState<string>("")
    const [password, setPassword] = useState<string>("")

    let res : any;


    const registerUser = () =>{
        if(firstName === ""){
            ToastError("choisissez le prenom !")
        } else if(lastName === ""){
            ToastError("choisissez le nom !");
        }else if(email === ""){
            ToastError("choisissez le email !");
        }else if(password === ""){
            ToastError("choisissez le password !");
        }else if (email !== ""  && password !== "" && lastName !== "" && firstName !== ""){
            res = RegisterService({firstName, lastName, email, password});
            ToastSuccess("inscription réussie !");
        }
    }
    return (
    <div>
   <NavBar/>
        <div className="flex h-[56rem] min-h-full">
            <div className="flex flex-row w-full">
                <ToastContainer
                    position="top-right"
                    autoClose={5000}
                    hideProgressBar={false}
                    newestOnTop={false}
                    closeOnClick
                    rtl={false}
                    pauseOnFocusLoss
                    draggable
                    pauseOnHover
                    theme="colored"
                />
                <div className="backgroundImage"></div>
                <div className="flex flex-col items-center justify-center px-52  relative">
                    <div className="flex lg:hidden justify-between items-center w-full py-4">
                        <div className="flex items-center justify-start space-x-3">
                            <span className="bg-black rounded-full w-6 h-6"></span>
                            <a  className="font-medium text-lg">Brand</a>
                        </div>
                        <div className="flex items-center space-x-2">
                            <span>Not a member? </span>
                            <a className="underline font-medium text-[#070eff]">
                                Sign up now
                            </a>
                        </div>
                    </div>
                    <div className="flex flex-1 flex-col  justify-center space-y-5 max-w-md">
                        <div className="flex flex-col space-y-2 text-center">
                            <h2 className="text-4xl md:text-4xl font-bold">Inscrivez-vous ici</h2>
                        </div>
                        <div className="flex flex-col max-w-md space-y-2">
                            <p className="flex justify-start ">Nom</p>
                            <input onChange={(e) => setLastName(e.target.value)}  type="text" placeholder="Username" className="flex  md:px-4 md:py-3 border-2 border-black rounded-lg font-medium placeholder:font-normal" />

                            <p className="flex justify-start">Prenom</p>
                            <input onChange={(e) => setFirstName(e.target.value)}  type="text" placeholder="Username" className="flex px-3 py-2 md:px-4 md:py-3 border-2 border-black rounded-lg font-medium placeholder:font-normal" />

                            <p className="flex justify-start" >Email</p>
                            <input onChange={(e) => setEmail(e.target.value)} type="email" placeholder="Username" className="flex px-3 py-2 md:px-4 md:py-3 border-2 border-black rounded-lg font-medium placeholder:font-normal" />

                            <p className="flex justify-start">Password</p>
                            <input  onChange={(e) => setPassword(e.target.value)} type="text" placeholder="Username" className="flex px-3 py-2 md:px-4 md:py-3 border-2 border-black rounded-lg font-medium placeholder:font-normal" />


                            <button onClick={registerUser} className="flex items-center justify-center flex-none px-3 py-2 md:px-4 md:py-3 border-2 rounded-lg font-medium border-black bg-black text-white">Confirm</button>
                            <div className="flex justify-center items-center">
                                <span className="w-full border border-black"></span>
                                <span className="px-4">Or</span>
                                <span className="w-full border border-black"></span>
                            </div>
                            <button className="flex items-center justify-center flex-none px-3 py-2 md:px-4 md:py-3 border-2 rounded-lg font-medium border-black relative">
              <span className="absolute left-4">
                <svg width="24px" height="24px" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg" xmlnsXlink="http://www.w3.org/1999/xlink">
                  <path fill="#EA4335 " d="M5.26620003,9.76452941 C6.19878754,6.93863203 8.85444915,4.90909091 12,4.90909091 C13.6909091,4.90909091 15.2181818,5.50909091 16.4181818,6.49090909 L19.9090909,3 C17.7818182,1.14545455 15.0545455,0 12,0 C7.27006974,0 3.1977497,2.69829785 1.23999023,6.65002441 L5.26620003,9.76452941 Z"/>
                  <path fill="#34A853" d="M16.0407269,18.0125889 C14.9509167,18.7163016 13.5660892,19.0909091 12,19.0909091 C8.86648613,19.0909091 6.21911939,17.076871 5.27698177,14.2678769 L1.23746264,17.3349879 C3.19279051,21.2936293 7.26500293,24 12,24 C14.9328362,24 17.7353462,22.9573905 19.834192,20.9995801 L16.0407269,18.0125889 Z"/>
                  <path fill="#4A90E2" d="M19.834192,20.9995801 C22.0291676,18.9520994 23.4545455,15.903663 23.4545455,12 C23.4545455,11.2909091 23.3454545,10.5272727 23.1818182,9.81818182 L12,9.81818182 L12,14.4545455 L18.4363636,14.4545455 C18.1187732,16.013626 17.2662994,17.2212117 16.0407269,18.0125889 L19.834192,20.9995801 Z"/>
                  <path fill="#FBBC05" d="M5.27698177,14.2678769 C5.03832634,13.556323 4.90909091,12.7937589 4.90909091,12 C4.90909091,11.2182781 5.03443647,10.4668121 5.26620003,9.76452941 L1.23999023,6.65002441 C0.43658717,8.26043162 0,10.0753848 0,12 C0,13.9195484 0.444780743,15.7301709 1.23746264,17.3349879 L5.27698177,14.2678769 Z"/>
              </svg>
              </span>
                                <span>Sign in with Google</span>
                            </button>
                        </div>
                    </div>

                    <div className="flex justify-center flex-col m-auto mb-16 text-center text-lg dark:text-slate-200 ">
                        <p className="font-bold mb-1">Built by <a href="#" className="underline dark:text-white">Frank Esteban</a></p>
                        <p>Contact me on the different platforms and social networks</p>

                    </div>

                </div>
            </div>

        </div>

    </div>
    );
};

export default Register;