import { apiClient } from "@/services/api.services"
import { useQuery } from "react-query";
import { Product } from "../types";

type GetProductsOptions = {
    params?: {

    }
}

export const getProducts = ({ params }: GetProductsOptions): Promise<Product[]> => {
    return apiClient.get('/products', { params });
}

export const useProducts = () => {
    const { data } = useQuery({
        queryKey: "products",
        queryFn: () => getProducts({}),
        initialData: []
    })

    return {
        data: data ?? []
    }
}