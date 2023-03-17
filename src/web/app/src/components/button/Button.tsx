import { ReactNode } from 'react';
import styled from 'styled-components';

export type ButtonProps = {
  appearance?:
    | 'primary'
    | 'outline'
    | 'subtle'
    | 'transparent';
  icon?: ReactNode;
};

export const Button = styled.button<ButtonProps>``;
