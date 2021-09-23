import HomePage from '../../features/home/HomePage';
import Header from './Header';

// const AppContainer = styled.div`
//   font-family: ${fontFamily};
// `;

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Header />
      </header>
      <HomePage />
    </div>
  );
}

export default App;
