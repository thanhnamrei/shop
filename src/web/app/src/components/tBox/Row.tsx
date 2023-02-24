import classNames from 'classnames';
import clsx from 'clsx';
import React from 'react';
import styled from 'styled-components';

type RowProps = {
  children?: React.ReactNode;
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

const View = ({
  children,
  mainAxisAlignment = 'start',
  crossAxisAlignment = 'start',
  gap = 4,
}: RowProps) => {
  return (
    <div
      className={classNames(`flex`, {
        [`justify-${mainAxisAlignment}`]: true,
        [`items-${crossAxisAlignment}`]: true,
        [`gap-x-${gap}`]: true,
      })}
    >
      {children}
    </div>
  );
  //   return styled.div`
  //     display: flex;
  //     justify-content: center;
  //     align-items: center;
  //     column-gap: 10px;
  //   `;
};
export default View;
