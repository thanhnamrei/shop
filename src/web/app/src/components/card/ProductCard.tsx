import { Product } from "../../models/Product.model";
import IconButton from "../button/IconButton";
import { FaHeart } from "react-icons/fa";
import { useContext } from "react";
import { FavoriteContext } from "../../providers/FavoriteProvider";

interface Props {
  product: Product;
}

const View = ({ product }: Props) => {
  const { addProduct } = useContext(FavoriteContext);

  return (
    <div className=" bg-white border shadow-md rounded-md p-6 w-48">
      <div> {product.productName} </div>
      <div>${product.unitPrice}</div>
      <IconButton onClick={() => addProduct(product)}>
        <FaHeart />{" "}
      </IconButton>
    </div>
  );
};
export default View;
