// averiguar la diferencia entre un objeto y un arreglo

var lenguajes = ['JavaScript', 'Python', 'Java'];

var persona = {nombre: 'Eduardo', apellido: 'Gordillo', codigo : 123456}

console.log(lenguajes[0]);
console.log(persona.nombre, persona['apellido']);

console.log(Object.keys(persona));
                                               
let keys = Object.keys(persona);

console.log(keys)

for(let i = 0 ; i < keys.length; i++){
    console.log(persona[keys[i]])
} 
