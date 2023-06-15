import { Entity } from '@/types';

export type Product = Entity & {
  name: string;
  productNumber: string;
  size: string;
  weight: number;
  color: string;
  standardCost: number;
  productSubcategoryId: number;
  createdDate: Date | null;
  createdBy: number | null;
  modifiedDate: Date | null;
  modifiedBy: number | null;
  productSubcategory: ProductSubcategory;
  productReviews: ProductReview[];
};

export type ProductReview = {
  productId: number;
  reviewerName: string;
  reviewDate: string;
  emailAddress: string;
  comments: string;
};

export type ProductSubcategory = Entity & {
  categoryId: number;
  name: string;
};

export type CreateProductData = Pick<Product, 'id'>; //hay
