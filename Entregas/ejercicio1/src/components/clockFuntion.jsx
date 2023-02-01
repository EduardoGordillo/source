import React , {useState} from 'react';


const nombre = "Eduardo";
const apellido = "Gordillo"
var edad = 0;


const ClockFuntion = () => {
    const [stateFecha, setFecha] = useState(new Date().toLocaleTimeString());
    const [Edad, setEdad] = useState(edad);

    var thick = ()=>{
        
        setFecha(new Date().toLocaleTimeString());
        setEdad(Edad +1);
        edad = Edad;

        
    }
    setInterval(thick, 1000);
    return (
        <div>
              <h1>Hora: {stateFecha}</h1>
              <h2>Edad: {edad}</h2>
        </div>
    );
}

export default ClockFuntion;
