import { Product } from "../models/Product.model";
import apiService from "./api.service";

export const getProducts = async () => {
  try {
    const response = await apiService.get<Product[]>("/api/Products");
    return response.data as Product[];
  } catch (error) {}
};
