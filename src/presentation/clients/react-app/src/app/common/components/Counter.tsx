/** @jsxImportSource @emotion/react */
import React, { ChangeEvent, useEffect, useState } from 'react';
import { css } from '@emotion/react';
import { FaPlus, FaMinus } from 'react-icons/fa';

interface Props {
  maxCount: number;
  minCount?: number;
  onChange: (value: number) => void;
}

export default function Counter({ minCount = 0, maxCount, onChange }: Props) {
  const [count, setCount] = useState<number>(1);

  const handleMinus = () => {
    if (count === 0) {
      return;
    }
    setCount((prevCount) => prevCount - 1);
  };

  const handlePlus = () => {
    if (count === maxCount) {
      return;
    }
    setCount((prevCount) => prevCount + 1);
  };

  const handleInputChange = (event: ChangeEvent<HTMLInputElement>) => {
    const value = +event.target.value;
    if (value >= maxCount) {
      setCount(maxCount);
    } else {
      setCount(value);
    }
  };

  useEffect(() => {
    onChange(count);
  }, [count, onChange]);

  return (
    <span>
      <button onClick={handleMinus} disabled={count === 1}>
        <FaMinus />
      </button>
      <input
        css={css`
          display: inline-block;
          width: 40px;
          text-align: center;
        `}
        value={count || ''}
        onChange={handleInputChange}
      />
      <button onClick={handlePlus} disabled={count === maxCount}>
        <FaPlus />
      </button>
    </span>
  );
}
