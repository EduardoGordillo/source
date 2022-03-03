// object create
var BF = {
  titulo: 'Batlefield',
  genero: 'FPS',
  jugar: function()
  {
    console.log('Estoy jugando a '+ this.titulo);
  }
  
};

var BF1 = Object.create(BF);

BF1['version'] = 'Battlefield 1';
console.log(BF1);
console.log(BF.isPrototypeOf(BF1));

// sintax sugar con object create
/*var objeto1 = {};
objeto1.propiedad = "";

var objeto2 = Object.create(Object.prototype);
console.log(Object.prototype.isPrototypeOf(objeto1));*/

// new

function COD(){
  this.titulo = 'Call of duty';
  this.genero = 'FPS';
  this.jugar = function(){
    console.log('Estoy jugando a ' + this.titulo);
  };
  
    
};

COD.prototype.Disparar = function(){
  console.log("pum pum");
  
};

var IW = new COD();

IW['version'] = 'infinite Warfare';
console.log(COD.isPrototypeOf(IW));

console.log(IW);

