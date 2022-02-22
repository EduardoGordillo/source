var contador = 1;

            while(contador <= 10)
            {
                console.log(contador);
                contador = contador + 1;
            }
            for (var i = 0; i < 10; i++)
            {
            
                console.log("Continua el programa");
            }
            do 
            {
                console.log(contador);
                contador ++;
            }
            while (contador <10)
            var nombre = prompt('introduce tu nombre de usuario');
console.log(nombre);
if (nombre && nombre.trim())
  {
  var confirmar = confirm ("es el usario correcto?");
  if (confirmar)
     {
    console.log("usuario correcto");
  }
    else {
      console.log("usuario incorrecto")
    }
  
    }
 
else {console.log('usuario incorrecto');}
var respuesta = 25.2;

if (typeof respuesta === "string" )
  {
    console.log("OK");
  }
else {
  console.log("Erro el tipo de valor es " + typeof respuesta);
}