import styled from 'styled-components';

export const Container = styled.div`
  width: 100%; //xs
  margin: auto;

  @media only screen and (min-width: 768px) {
    //sm
    width: 100%;
  }

  @media only screen and (min-width: 992px) {
    // md
    width: 100%;
  }

  @media only screen and (min-width: 1200px) {
    // lg
    max-width: 1140px;
  }
`;
