import React, { useEffect, useState } from 'react';
import axios from 'axios';


export const useGetData : (name: any) => any[] = (name) => {
    const [data, setData] = useState<any[]>([]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await axios.get(`${process.env.REACT_APP_URL}${name}`);
                const allData = response.data;
                setData(allData);
            } catch (error) {
                console.error(error);
            }
        };

        fetchData();
    }, [name]);

    return data;
};