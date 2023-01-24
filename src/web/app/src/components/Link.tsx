interface LinkProps {
  to: string;
  children?: React.ReactNode;
}

const View = ({ to, children }: LinkProps) => {
  return <a href={to}>{children}</a>;
};
export default View;
