import { Product } from "../types"
import { Text } from '@/components/text'

export const ProductInfo = ({ product }: { product: Product }) => {
    return <>
        <Text>{product.name}</Text>
        <Text>{product.productNumber}</Text>
        <Text>{product.color}</Text>
        <Text>{product.weight}</Text>
        <Text>{product.size}</Text>

        {
            product.productReviews
            && product.productReviews.length
            && (<div></div>)
        }
    </>
}