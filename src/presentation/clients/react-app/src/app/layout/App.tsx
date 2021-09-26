import ProductList from '../../features/product/ProductList';
import Header from './Header';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import ProductDetail from '../../features/product/ProductDetail';

function App() {
  return (
    <BrowserRouter>
      <div>
        <Header />
        <Routes>
          <Route path="" element={<ProductList />} />
          <Route path="/:id" element={<ProductDetail />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
