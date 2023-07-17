import axios from "axios";


interface registerClass
{
    lastName : string;
    firstName : string;
    email : string;
    password : string;
}
 export const RegisterService = async(payload: registerClass)  => {
     try {
         return await axios.post(`${process.env.REACT_APP_URL}User/register`,{
             lastName : payload.lastName,
             firstName : payload.firstName,
             email : payload.email,
             password : payload.password,
         })
     } catch (error) {
         console.error(error);
     }
}
