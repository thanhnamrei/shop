/** @jsxImportSource @emotion/react */
import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import { Page } from '../../app/layout/Page';
import { css } from '@emotion/react';
import styled from '@emotion/styled';
import productsData from '../../app/data/product.json';
import { wait } from '../../app/common/funcs';
import { Product } from '../../app/models/product/Product';
import { FaStar } from 'react-icons/fa';
import Counter from '../../app/common/components/Counter';

const container = css`
  display: flex;
  img {
    width: 30%;
  }
`;

const Button = styled.button`
  background: transparent;
  border: 1px solid palevioletred;
  color: palevioletred;
  padding: 0.25em 1em;
  cursor: pointer;
`;

export default function ProductDetail() {
  const { id } = useParams();
  const [product, setProduct] = useState<Product | undefined>(undefined);

  useEffect(() => {
    const doGetProduct = async () => {
      wait(1000);
      setProduct(productsData.find((p) => p.id === id));
    };
    doGetProduct();
  }, [id]);

  return (
    <Page>
      {product && (
        <>
          <div css={container}>
            <img src="" alt="" />
            <div>
              <h1>{product.name}</h1>
              <span>{product.rating}</span>
              <FaStar />| <span>Review</span>
              <p>${product.price}</p>
              <p>
                <span>Quantity</span>
                <Counter maxCount={10} onChange={(value) => {}} />
                <span>In Stock</span>
              </p>
              <Button>Add Card</Button>
            </div>
          </div>
          <div>
            <h1>Product details</h1>
            <p>
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque
              molestiae autem dolore quo ipsum officiis eius debitis excepturi,
              porro cupiditate tenetur nesciunt? Minus ea in est quis, pariatur
              beatae quam!
            </p>
          </div>
          <div>
            <h1>Product description</h1>
            <p>
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque
              molestiae autem dolore quo ipsum officiis eius debitis excepturi,
              porro cupiditate tenetur nesciunt? Minus ea in est quis, pariatur
              beatae quam!
            </p>
          </div>
          <div>
            <h1>US PRODUCT REVIEW</h1>
            <p>ABC</p>
            <p>Lorem ipsum dolor</p>
          </div>
        </>
      )}
    </Page>
  );
}
