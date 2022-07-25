var persona = {
  nombre: "Edd",
  edad: 36,
  ocupacion: "Developer",
  color: "rojo",
  nacion: "Mexico",
  
  
  caminar: function (){
    console.log("Estoy caminando");
  },
  saludar: function(){
    
    console.log("Hola buenas tardes me llamo " + this.nombre);
    
    var funcion = function()
    {
      console.log(this.nombre);
    }.bind(this);// añadiendo bind toma this como una variable de ambito local
    funcion();// esto es llamar a una funcion sencilla
  },
 
  
  
}

persona.saludar();

// this si lo mandamos como metodo de un objeto 
// this hara referencia al objeto

// si lo mandamos como una funcion sencilla aunque este dentro 
// del objeto this toma la variable de ambito global
    
