function mostrarSaludo(){
    var mensaje = 'Hola... este codigo se ejecuta en una funcion';
    console.log(mensaje);
}
//console.log(mensaje); // ReferenceError: <<identificador>> is not defined
mostrarSaludo();


var numero = 7;
function mostrarNumero(){
    console.log(`El numero es : ${numero}`);

}
mostrarNumero();


