import { useEffect, useState } from "react";
import ProductCard from "../components/card/ProductCard";
import { Product } from "../models/Product.model";
import { getProducts } from "../services/product.service";

const View = () => {
  const [products, setProducts] = useState<Product[]>([]);
  useEffect(() => {
    const doGetProducts = async () => {
      const result = await getProducts();
      setProducts(result || []);
    };

    doGetProducts();
  }, []);

  return (
    <div className="flex flex-wrap gap-6 justify-center">
      {products.map((p) => (
        <ProductCard key={p.productId} product={p} />
      ))}
    </div>
  );
};
export default View;
