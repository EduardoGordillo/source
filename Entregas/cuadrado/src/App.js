import logo from './logo.svg';
import './App.css';
import Cuadrado from './components/cuadrado';

function App() {
  return (
    <div className="App">
      <header className="App-header">
      Nombre : Eduardo Gordillo <br/>
      Correo : edwardgord13@gmail.com
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Posa el mouse para iniciar el efecto, cuando salgas o hagas doble click en el cuadrado se detendra el efecto 
        </p>
        <Cuadrado ></Cuadrado>
        
      </header>
    </div>
  );
}

export default App;
