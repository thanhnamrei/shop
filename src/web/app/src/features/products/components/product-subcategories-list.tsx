import { ProductSubcategory } from "../types"

export type ProductSubcategoriesListProps = {
    categories: ProductSubcategory[],
    isLoading?: boolean
}

export const ProductSubcategoriesList = ({ categories, isLoading }: ProductSubcategoriesListProps) => {
    return <div>
        <h1>Danh mục</h1>
        <ul>
            {
                categories.map(c => <li key={c.id}>{c.name}</li>)
            }
        </ul>
    </div>
}