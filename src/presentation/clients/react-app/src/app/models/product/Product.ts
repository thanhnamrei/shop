export interface Product {
  id: string;
  imageUrl: string;
  name: string;
  description: string;
  price: number;
  rating: number;
  inStock?: number;
}
