import styled from 'styled-components';

const variants = {
  primary: {},
  default: {},
  none: {},
};

export type ButtonProps = {
  variant: keyof typeof variants;
};

export const Button = styled.button<ButtonProps>`
  ${({ variant }) => 'background-color:white'}
`;
