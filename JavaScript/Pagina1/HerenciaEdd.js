// anti-pattern
Object.prototype.saludar = function()
{
  console.log("Hola soy " + this.nombre);
}

var juan = 
    {
      nombre: "Juan",
      profesion: "Dev",
      ciudad: "Madrid",
      
      
    };
juan.saludar();

var andres =
    {
      nombre: "Andres",
      profesion: "Pintor",
      ciudad: "Valencia",
      
      
    };
andres.saludar();
