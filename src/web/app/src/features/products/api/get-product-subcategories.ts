import { apiClient } from "@/services/api.services"
import { useQuery } from "react-query"
import { ProductSubcategory } from "../types"

export const getProductSubcategories = (): Promise<ProductSubcategory[]> => {
    return apiClient.get('/Products/Categories')
}

export const useProductSubcategories = () => {
    const {data,isFetching,isFetched} = useQuery({
        queryKey: "categories",
        queryFn: () => getProductSubcategories(),
        initialData: []
    });

    return {
        data,
        isLoading: isFetching && !isFetched
    }
}
