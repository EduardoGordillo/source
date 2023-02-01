import logo from './logo.svg';
import './App.css';
//import ContactoList from './components/contactoList';
//import Clock from './components/clock';
import ClockFuntion from './components/clockFuntion';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <ClockFuntion></ClockFuntion>
        
      </header>
    </div>
  );
}

export default App;
