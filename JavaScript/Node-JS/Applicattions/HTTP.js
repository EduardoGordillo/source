const os = require('os');
const fs = require('fs');
// codigo resultante

const platform = os.platform();
console.log(platform);// este codigo permite continuar 
//con la siguiente  linea de codigo hasta que acabe su proceso
console.log(os.release());
console.log('free mem:', os.freemem(), ' bytes');
console.log('total mem:', os.totalmem(), ' bytes');

/*
// codigo asincrono
// aunque no se halla terminado de ejecutar el codigo permite que siga corriendo
// con la lineas siguientes codigo 

fs.writeFile('./texto.txt','linea uno', (err)=>{
    if(err){
        console.log(err);
    }
    console.log('Archivo Creado');
});*/
fs.readFile('./texto.txt', function (err, data){
    if(err){
        console.log(err);
    };

    console.log(data.toString());
});


console.log('ultima linea');