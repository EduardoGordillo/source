// hoisting (alzado)

var expresionFuncional = function()
{
 console.log("Hola desde expresion funcional"); 
};
expresionFuncional();

function obtenerNumero(){
  function retornarNumero()
  
  {
    return 80;
    
  }
  return retornarNumero();
  function retornarNumero(){
    return 50;
  }
}
console.log(obtenerNumero());

 function obtenerNumeros(){
  var retornarNumero = function()
  
  {
    return 80;
    
  }
  
  var retornarNumero = function(){
    return 800;
    
  }
  return retornarNumero
  }
console.log(obtenerNumeros());