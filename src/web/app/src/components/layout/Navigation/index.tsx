import IconButton from "../../button/IconButton";
import NavBar from "./NavBar";
import { FaRegHeart, FaUser, FaCartPlus } from "react-icons/fa";
import {
  FavoriteContext,
  FavoriteProductState,
} from "../../../providers/FavoriteProvider";
import { useContext } from "react";

const View = () => {
  const { products } = useContext(FavoriteContext) as FavoriteProductState;
  return (
    <div className="flex justify-between py-5 px-5 bg-gray-300 shadow-md">
      <NavBar />
      <div className="flex gap-4">
        <div className=" relative inline-block">
          <IconButton>
            <FaRegHeart />
          </IconButton>
          <div className=" absolute left-full -top-3 text-white">
            {products.length}
          </div>
        </div>
        <IconButton>
          <FaUser />
        </IconButton>
        <IconButton>
          <FaCartPlus />
        </IconButton>
      </div>
    </div>
  );
};
export default View;
