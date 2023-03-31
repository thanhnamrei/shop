import Image from '@/components/image';
import styled from 'styled-components';

type AvatarProps = {
  icon?: string;
  image?: string;
  name?: string;
  shape?: 'circular' | 'square';
  color?: string;
  active?: 'active' | 'inactive' | 'unset';
  size?: number;
};

const Wrapper = styled.div<AvatarProps>`
  ${({ size, color, shape }) => `
    display: flex;
    justify-content: center;
    align-items: center;
    width: ${size}px;
    height: ${size}px;
    background-color: ${color ?? 'gray'};
    border-radius: ${shape === 'circular' ? '100%' : ''};
  `}
`;

const View = ({
  size = 32,
  color,
  image,
  name,
  icon,
  shape = 'square',
}: AvatarProps) => {
  return (
    <Wrapper size={size} shape={shape}>
      {image && <Image src={image} alt="" />}
      {name && name}
    </Wrapper>
  );
};

export default View;
