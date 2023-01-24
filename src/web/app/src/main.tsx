import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App";
import "./index.scss";
import { createBrowserRouter, RouterProvider } from "react-router-dom";
import { router } from "./routes";
import { FavoriteProvider } from "./providers/FavoriteProvider";

ReactDOM.createRoot(document.getElementById("root") as HTMLElement).render(
  <React.StrictMode>
    <FavoriteProvider>
      {/* <RouterProvider router={router} /> */}
      <App />
    </FavoriteProvider>
  </React.StrictMode>
);
