import React, { useEffect, useRef, useState } from 'react';
import { usePrevious } from '../../app/common/hooks/usePrevious';

const TestComponent = ({ numbers = [] }) => {
  const [valueNumbers, setValueNumbers] = useState(numbers);
  const prevAmount = usePrevious({ numbers });
  const [, setValue] = useState('');
  useEffect(() => {
    if (!numbers?.length) return;
    setValueNumbers(numbers);
  }, [numbers]);

  return (
    <>
      <input type="text" onChange={(e) => setValue(e.target.value)} />{' '}
      {valueNumbers.map((n) => (
        <p key={n}>{n}</p>
      ))}
    </>
  );
};

export default function HomePage() {
  const [show, setShow] = useState(true);
  // const [value, setValue] = useState(0);
  return (
    <div>
      <p>Home</p>
      {show && <TestComponent />}
    </div>
  );
}
