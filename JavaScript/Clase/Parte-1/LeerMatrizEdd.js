var matriz = ["lunes", "Martes", "Miercoles", "Jueves", "Viernes"];

var longitud = matriz.length, n = 0; 
for (n ;n < longitud; n++ )
  {
    console.log(matriz[n]);
  }

function mostrarElemento(elemento)
{
  console.log(elemento);
}
matriz.forEach(mostrarElemento);

//ESNEXT for of
// var se usa para un contexto general
// let es una variable para ambito local de la function donde se ocupe


for (let elemento of matriz)
  {
    console.log(elemento);
  }