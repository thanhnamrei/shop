import HomePage from '../../features/home/HomePage';
import TourPackagePage from '../../features/tour-package/TourPackagePage';
import Header from './Header';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Header />
      </header>
      <TourPackagePage />
      <HomePage />
    </div>
  );
}

export default App;
