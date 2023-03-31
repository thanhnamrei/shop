import styled from 'styled-components';

type AvatarProps = {
  icon?: string;
  image?: string;
  name?: string;
  shape?: 'circular' | 'squire';
  color?: string;
  active?: 'active' | 'inactive' | 'unset';
  size?: number;
};

const Div = styled.div<AvatarProps>`
  width: 32px;
  height: 32px;
  background-color: gray;
  border-radius: 100%;
`;

const View = (props: AvatarProps) => {
  return <Div></Div>;
};

export default View;
