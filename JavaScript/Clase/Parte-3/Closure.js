// closure

function funcion1()
{
  var miVariable = 1;
  function funcionInterna()
  {
    console.log(miVariable);
    
  }
  return funcionInterna;
}
var variableExterna = funcion1();

//console.log(variableExterna);
variableExterna();

function funcion2()
{
  var miVariable = 2;
  function funcionInterna()
  {
    console.log(miVariable);
  }
  if (variable == "funcion1")
  funcionExterna(funcionInterna);
  if (variable == "funcion2")
  funcionExterna(funcionInterna2);
}
function funcionExterna(funcion){
  funcion();
}

funcion2();
function espera (mensaje){
    setTimeout(function()
              {
      console.log(mensaje)
    }, 2000)
    
  }
  espera('hola desde clousure');


  var Counter = (function() {
    var privateCounter = 0;
    function changeBy(val) {
      privateCounter += val;
    }
    return {
      increment: function() {
        changeBy(1);
      },
      decrement: function() {
        changeBy(-1);
      },
      value: function() {
        return privateCounter;
      }
    }
  })();
  
  alert(Counter.value()); /* Muestra 0 */
  Counter.increment();
  Counter.increment();
  alert(Counter.value()); /* Muestra 2 */
  Counter.decrement();
  alert(Counter.value()); /* Muestra 1 */ 
  
  for (var i = 0; i <= 5; i++)
  {
    
    (function (z){
      setTimeout(function(){
      console.log(z)
      
    }, z*1000);})(i);
  }
