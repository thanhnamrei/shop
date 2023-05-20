import { apiClient } from "@/services/api.services"
import { useQuery } from "react-query";

type GetProductsOptions = {
    params: {

    }
}

export const getProducts = ({params}: GetProductsOptions) => {
    return apiClient.get('/products',{params});
}

export const useProducts = () => {
    const {} = useQuery({
        
    })
}