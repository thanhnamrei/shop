import styled from 'styled-components';

export type LabelProps = {
  required?: boolean;
};
export const Label = styled.label<LabelProps>`
  ${({ required }) =>
    required ? `::after {content: '*'; color: red;}` : ''}
`;
