import { ReactNode } from "react"
import { QueryClient, QueryClientProvider } from "react-query"

type AppProviderProps = {
    children: ReactNode
}
const queryClient = new QueryClient({});

export const AppProvider = ({ children }: AppProviderProps) => {
    return (
        <QueryClientProvider client={queryClient}>
            {children}
        </QueryClientProvider>
    );
}