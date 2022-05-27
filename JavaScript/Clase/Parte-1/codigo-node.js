console.log('JavaScript!');
function saludar(nombre){
    console.log(`Hola ${nombre}, Bienvenido`);
}
saludar('Eduardo');

setTimeout(()=>{
    console.log('Este Texto se mostrara en los proximos 5 segundos')
},5000);

console.log('Fin')