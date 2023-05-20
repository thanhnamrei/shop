import { Entity } from "@/types";

export type Product =  Entity & {

}

export type CreateProductData = Pick<Product, 'id'>; //hay