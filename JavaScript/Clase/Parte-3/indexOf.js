var colores = ['rojo', 'verde','blanco', 'azul' ];
//colores.push('morado');
//console.log(colores.indexOf('morado'));
function borrarElementoMatriz(elemento, matriz)
{
  var indice = matriz.indexOf(elemento);
  
  
  
  if(indice >-1){
    var nombre =colores.splice(indice,1);
    console.log(nombre);
  }
  else
    {
      alert('No existe el elemento');
    }
}

borrarElementoMatriz('blanco', colores);


