let persona = {nombre :'Eduardo', apellido: 'Gordillo', id :156548, correo:'live_carr@hotmail.com'};

console.log(typeof Object.keys(persona));
console.log(Object.keys(persona) instanceof Array);
console.log(Object.keys(persona));

Object.keys(persona).forEach((valor)=>{
    console.log(valor)
});