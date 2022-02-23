// objeto la coleccion de informacion relacionada de alguna forma
// los objetos se crean con las llaves
// conjunto de propiedades y valores
// con dot accedemos a las propiedades 
// {} estas llaves es un object literal expresion
// cuando una propiedad contiene una funcion es un metodo
var funcion1 =  (function fun(){
  console.log(prompt());
})();
    
var libro = {
  titulo: "IT",
  autor: "Stephen king",
  genero: "Terror",
  valoracion: 9,
  tags: ["Pennywise", "floating", "payaso", "Derry"],
  funcion1: funcion1
};
console.log(libro.funcion1);