import React from 'react';
import styled from 'styled-components';

type FontWeights =
  | 'regular'
  | 'medium'
  | 'semibold'
  | 'bold';

type TextProps = {
  as?: 'h1' | 'p' | 'span' | 'div' | 'pre';
  children: React.ReactNode;
  className?: string;
  underline?: boolean;
  italic?: boolean;
  size?: number;
  weight?: FontWeights;
};

const _makeFontWeight = (weight?: FontWeights) => {
  switch (weight) {
    case 'medium':
      return 500;
    case 'semibold':
      return 600;
    case 'bold':
      return 700;
    case 'regular':
    default:
      return 400;
  }
};

export const Text = styled.p<TextProps>`
  font-weight: ${({ weight }) => _makeFontWeight(weight)};
  font-size: ${({ size }) => `${size ?? 14}px`};
  /* ${({ italic }) => italic && 'font-style:italic;'} */
`;
