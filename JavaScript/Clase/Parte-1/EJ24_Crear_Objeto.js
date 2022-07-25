// Crear y asignar propiedades a un objeto

let computador = {
    cpu : 'Intel',
    nucleos : '8',
    ram : 16,

};

computador.almacenamiento = 256;
computador.board = 'ASUS';
console.log(computador);

console.log(computador.cpu)

computador.cpu = 'Intel Core i7 K900I'


console.log(computador)

computador = {
    board : 'MSI'
}
 
console.log(computador.board)

computador['tarjeta-grafica'] = 'Nvidia Gforce';

console.log(computador['tarjeta-grafica'])


