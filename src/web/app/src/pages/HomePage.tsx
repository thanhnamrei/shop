import Navigation from "../components/layout/Navigation";
import HeaderNav from "../components/layout/Navigation/HeaderNav";
import ProductContainer from "../containers/ProductContainer";

function HomePage() {
  return (
    <div className="App">
      <header className="App-header text-center">
        <HeaderNav />
        <Navigation />
      </header>
      <main>
        <ProductContainer />
      </main>

      <footer></footer>
    </div>
  );
}

export default HomePage;
