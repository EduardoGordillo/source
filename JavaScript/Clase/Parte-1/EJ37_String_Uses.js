// usar el contenido de una variable en una cadena
let numero = 6;
let cadena = 'JavaScript numero';
console.log(cadena);
cadena = "JavaScript numero";
console.log(cadena);
cadena = `JavaScript ${numero +1}`; // inyeccion de variables en una cadena 
console.log(cadena);

let persona = {
    nombre: 'Eduardo',
    apellido : 'Gordillo',
    id : 15
}

console.log(`Su nombre completo es `+ persona.nombre +' ' + persona.apellido +
' y su ID es '+ persona.id);
console.log(`Su nombre completo es ${persona.nombre} ${persona.apellido} y su ID es ${persona.id}`);

