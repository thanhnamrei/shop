import Image from 'next/image';

type ImageProps = {
  src: string;
  alt: string;
};
const View = ({ src, alt }: ImageProps) => {
  return <Image src={src} alt={alt}></Image>;
};

export default View;
