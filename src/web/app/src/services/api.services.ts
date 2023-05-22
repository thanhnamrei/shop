import { API_URL } from '@/config/constants';
import axios from 'axios';

export const apiClient = axios.create({
    baseURL: 'https://localhost:7165/api',
    headers: {
        'Content-Type': 'application/json'
    }
});


apiClient.interceptors.response.use(
    (response) => {
        return response.data
    },
    (error) => {
        console.log(error)
        return Promise.reject(error)
    }
);