/** @jsxImportSource @emotion/react */
import React, { useEffect, useState } from 'react';
import { wait } from '../../app/common/funcs';
import { Product } from '../../app/models/product/Product';
import ProductItem from './ProductItem';
import productsData from '../../app/data/product.json';
import { css } from '@emotion/react';
import { Page } from '../../app/layout/Page';

const list = css`
  display: flex;
  gap: 10px;
  justify-content: center;
`;

export default function ProductList() {
  const [products, setProducts] = useState<Product[]>([]);
  const [loading, setLoading] = useState(false);
  useEffect(() => {
    const doGetProducts = async () => {
      await wait(1000);
      setProducts(productsData);
    };
    setLoading(true);
    doGetProducts();
    setLoading(false);
  }, []);
  if (loading) return <p>Loading...</p>;

  return (
    <Page>
      <div css={list}>
        {products?.length && (
          <>
            <ProductItem product={products[0]} />
            <ProductItem product={products[0]} />
            <ProductItem product={products[0]} />
          </>
        )}

        {/* {products.map((product) => (
          <Item key={product.id}>
            <ProductItem product={product} />
          </Item>
        ))} */}
      </div>
    </Page>
  );
}
