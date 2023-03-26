import {
  ButtonHTMLAttributes,
  HtmlHTMLAttributes,
  ReactNode,
} from 'react';
import styled from 'styled-components';

export type ButtonProps = {
  appearance?:
    | 'primary'
    | 'outline'
    | 'subtle'
    | 'transparent';
  icon?: ReactNode;
  shape?: 'circle' | 'square';
};

const StyledButton = styled.button<ButtonProps>`
  padding: 4px 8px;
  /* border: 1px solid #f9fafb; */
  :hover {
    background-color: #f3f4f6;
  }
  ${({ appearance }) => {
    switch (appearance) {
      case 'transparent':
        return '';
      default:
        return 'border: 1px solid #f9fafb';
    }
  }}
`;

export default function Button({
  children,
  appearance,
  icon,
}: ButtonProps &
  ButtonHTMLAttributes<HTMLButtonElement>) {
  return <StyledButton>{children}</StyledButton>;
}
