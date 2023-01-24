import { createContext, useContext, useState } from "react";
import { Product } from "../models/Product.model";

export interface FavoriteProductState {
  products: number[];
  addProduct: Function;
  removeProduct: Function;
}

export const FavoriteContext = createContext<FavoriteProductState>({
  products: [],
  addProduct: () => null,
  removeProduct: () => null,
});

// export const useFavoriteProduct = useContext(FavoriteContext);

export const FavoriteProvider = ({ children }: any) => {
  const [products, setProducts] = useState<number[]>([]);
  const addProduct = (product: Product) => {
    if (!products.includes(product.productId)) {
      setProducts([...products, product.productId]);
    }
  };
  const removeProduct = (product: Product) => {
    if (products.includes(product.productId)) {
      const newProducts = products.filter((p) => p !== product.productId);
      setProducts(newProducts);
    }
  };
  return (
    <FavoriteContext.Provider value={{ products, addProduct, removeProduct }}>
      {children}
    </FavoriteContext.Provider>
  );
};
