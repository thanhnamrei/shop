import React, { useEffect, useState } from 'react';
import { wait } from '../../app/common/funcs';
import { Product } from '../../app/models/product/Product';
import ProductItem from './ProductItem';
import productsData from '../../app/data/product.json';
import styled from 'styled-components';

const Container = styled.div`
  margin-top: 50px;
`;

const List = styled.ul`
  list-style: none;
  display: flex;
  gap: 10px;
  justify-content: center;
`;

const Item = styled.li`
  width: 192px;
  border: 1px solid grey;
`;

export default function ProductList() {
  const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    const doGetProducts = async () => {
      await wait(1000);
      setProducts(productsData);
    };
    doGetProducts();
  }, []);
  return (
    <Container>
      {products?.length && (
        <List>
          <Item>
            <ProductItem product={products[0]} />
          </Item>
          <Item>
            <ProductItem product={products[0]} />
          </Item>
          <Item>
            <ProductItem product={products[0]} />
          </Item>
        </List>
      )}

      {/* {products.map((product) => (
          <Item key={product.id}>
            <ProductItem product={product} />
          </Item>
        ))} */}
    </Container>
  );
}
