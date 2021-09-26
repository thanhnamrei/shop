/** @jsxImportSource @emotion/react */
import React from 'react';
import { Product } from '../../app/models/product/Product';
import { FaStar } from 'react-icons/fa';
import { css } from '@emotion/react';
import { Link } from 'react-router-dom';

interface Props {
  product: Product;
}

const item = css`
  width: 192px;
  padding: 10px;
  box-shadow: 0 3px 10px rgb(0 0 0 / 0.2);
`;

const itemHeader = css`
  font-weight: bold;
  color: #700ed2;
`;

const itemFooter = css`
  display: flex;
  justify-content: space-between;
  span:first-child {
    color: red;
  }
`;

export default function ProductItem({ product }: Props) {
  return (
    <article css={item}>
      <img src={product.imageUrl} alt="product" />
      <h4 css={itemHeader}>{product.name}</h4>
      <div css={itemFooter}>
        <span>${product.price}</span>
        <span>
          {product.rating} <FaStar color="yellow" />
        </span>
      </div>
      <Link to={`/41fd4fd9-95c7-4809-96db-a147d352fdbb`}>View More...</Link>
    </article>
  );
}
