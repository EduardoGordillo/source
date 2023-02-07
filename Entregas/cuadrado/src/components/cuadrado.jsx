import React, {useState, useEffect, useRef} from 'react';

const Cuadrado = () => {
        var numeroRamdom = ()=>Math.floor(Math.random() * 255)

        const cuadradoNegro = {
            background: 'rgb(0 0 0)',
            height: '255px',
            width: '255px'
        }

        const colorRamdom  = {
            background: `rgb(${numeroRamdom()}  ${numeroRamdom()} ${numeroRamdom()})`,
            height: '255px',
            width: '255px' 
        }
        const [interval, setIntervalo] = useState(false);
        const [cuadrado, setcuadrado] = useState(cuadradoNegro);
        useEffect(() => {
            let inter;
            if(interval){
                inter = setInterval(()=>setcuadrado(colorRamdom), 100)
            }
            return () => {
                clearInterval(inter);
            };
        }, );
        function mouseOver(){
            
            setIntervalo(true)
           
            
        };
    
        function mouseOut(){
            setIntervalo(false)
          
            
        }
        function doubleClick(){
            setIntervalo(false)
            
        }
        

    return (
        <div style={{height:'290px', width: '290px'}}>
            <div  style={cuadrado} onMouseOver={mouseOver} onMouseOut={mouseOut} onDoubleClick={doubleClick} ></div>
        </div>
    );
}

export default Cuadrado;
