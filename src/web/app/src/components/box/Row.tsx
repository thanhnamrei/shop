import styled from 'styled-components';

type MainAxisAlignment =
  | 'start'
  | 'end'
  | 'center'
  | 'between'
  | 'around'
  | 'evenly';

type RowProps = {
  mainAxisAlignment?: MainAxisAlignment;
  crossAxisAlignment?: 'start' | 'end' | 'center';
  gap?: 0 | 1 | 2 | 3 | 4 | 5 | 6;
};

const _makeMainAxis = (align?: MainAxisAlignment) => {
  switch (align) {
    case 'start':
      return 'flex-start';
    case 'end':
      return 'flex-end';
    case 'center':
      return 'center';
    case 'between':
      return 'space-between';
    case 'around':
      return 'space-around';
    case 'evenly':
      return 'space-evenly';
    default:
      return 'flex-start';
  }
};

export const Row = styled.div<RowProps>`
  display: flex;
  column-gap: ${(props) => props.gap}px;
  align-items: center;
  justify-content: ${(props) =>
    _makeMainAxis(props.mainAxisAlignment)};
`;
