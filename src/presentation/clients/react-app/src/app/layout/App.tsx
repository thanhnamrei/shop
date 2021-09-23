import styled from 'styled-components';
import ProductList from '../../features/product/ProductList';
import { fontFamily } from '../common/theme/font';
import Header from './Header';

const AppContainer = styled.div`
  font-family: ${fontFamily};
`;

function App() {
  return (
    <AppContainer>
      <Header />
      <ProductList />
    </AppContainer>
  );
}

export default App;
