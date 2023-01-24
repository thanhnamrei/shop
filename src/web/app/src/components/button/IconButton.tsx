import { ReactNode } from "react";

interface IconButtonProps {
  children: ReactNode;
}

const View = ({ children, ...props }: any) => {
  return <button {...props}>{children}</button>;
};
export default View;
