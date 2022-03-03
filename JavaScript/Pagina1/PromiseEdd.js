let compras = "h";

function hacerLaCompra()
{
  return new Promise(function(resolve)
  {
    setTimeout(function(){
      compras += "hh"
      resolve()
    }, 20)
                     
                     });
}
hacerLaCompra()
  .then(() => hacerLaCompra())


  function temporizador(tiempo){
    return new Promise(function(resolve)
    {
      setTimeout(() => resolve(), tiempo)
      
    })
  }
  temporizador(2000)
  .then(() => console.log("FIN"))

  let desarrollo = new Promise(function(resolve, reject){
    // acciones necesarias para conseguir un resultado
    // satisfactorio
    
    
    setTimeout(() => {
      const proyecto = "Project"
      let rnd = Math.random()
      if (rnd < .4)
        {
          resolve(proyecto)
        }
      else
        {
         reject("No entregado a tiempo")
   
        }
    }, 2000); 
    })
  
  desarrollo
  .then((proyecto) => console.log(proyecto))
  .catch((error) => console.log(error))
  .finally(() => console.log('Promesa Finalizada'))
  
  
  