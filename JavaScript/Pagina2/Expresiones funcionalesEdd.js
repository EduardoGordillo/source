//Expresiones funcionales
// Toda funcion declarada tiene que tener un nombre
// javascript es un lenguaje interpretado y 
// la coloca al principio del cuerpo y puede ser llamada desde cualquier parte del cuerpo
// una expresion funcional consta de un valor que agrega un operador binario y declara un cuerpo

funcionDeclarada();


function funcionDeclarada()
{
  console.log("Declarada");
}

var expresionDeclarada = function(){
  console.log("Expresion");
  
};
expresionDeclarada();

var matriz = [1,2,3,4,5]

matriz.forEach(function(elemento){
  console.log('Elemento ' + elemento);
});

//expresiones funcionales que se incovan automaticamente

(function(){
  console.log("Hola desde IIFE");
  //inmediately invoked function expression
  
})();

