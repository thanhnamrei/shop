import { Entity } from "@/types";

export type Product =  Entity & {

}

export type ProductSubcategory = Entity & {
    categoryId: number;
    name: string;
}

export type CreateProductData = Pick<Product, 'id'>; //hay