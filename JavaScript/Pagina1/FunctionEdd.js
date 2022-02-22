function saludar (nombre)
{
  
  if (nombre == 'Edd')
    {
      console.log("Hola " + nombre);
      alert('Hola Edd');
    }
    else
      {
        console.log("Nombre no valido");
        var nomb = prompt("Ingresa Nombre");
        
      }
  
    return nombre.toUpperCase;
}


var nomb = prompt("Ingresa Nombre");

saludar(nomb);

function mayusculas (texto)
{
  return texto.toUpperCase();
}
var n = mayusculas('edd');
console.log(n);