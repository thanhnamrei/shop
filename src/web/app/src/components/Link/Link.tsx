import Link from 'next/link';

type LinkProps = {
  linkTo: string;
  children: React.ReactNode;
};

const View = ({ linkTo, children }: LinkProps) => {
  return <Link href={linkTo}>{children}</Link>;
};

export default View;
