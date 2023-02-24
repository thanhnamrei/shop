import classNames from 'classnames';
import clsx from 'clsx';
import React from 'react';
import styled from 'styled-components';

type RowProps = {
  mainAxisAlignment?:
    | 'start'
    | 'end'
    | 'center'
    | 'between'
    | 'around'
    | 'envenly';
  crossAxisAlignment?: 'start' | 'end' | 'center';
  gap?: 0 | 1 | 2 | 3 | 4 | 5 | 6;
};

export const Row = styled.div<RowProps>`
  display: flex;
  column-gap: ${(props) => props.gap}px;
`;
