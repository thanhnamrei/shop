import { Seo } from "@/components/seo"
import { useProductSubcategories } from "@/features/products"
import { ProductSubcategoriesList } from "@/features/products/components/product-subcategories-list";

const ProductPage = () => {
    const categories = useProductSubcategories();

    return (
        <>
            <Seo title="Products" />
            <ProductSubcategoriesList categories={categories.data || []} />
        </>
    )
}

export default ProductPage;