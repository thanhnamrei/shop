import React from 'react';
import { Product } from '../../app/models/product/Product';

interface Props {
  product: Product;
}

export default function ProductItem({ product }: Props) {
  return (
    <div>
      <img src={product.imageUrl} alt="Product" />
      <div>{product.name}</div>
      <div>{product.price}</div>
      <div>{product.description}</div>
      <div>{product.rating}</div>
    </div>
  );
}
