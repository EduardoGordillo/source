// usar el metodo forEach para recorrer un arreglo

let Yo = ['Eduardo Gordillo', 'Desarrollador', 27]

Yo.forEach(element => {
    //console.log(element+''+ (element[+1]))    
    console.log(element);
});
Yo.forEach((valor,indice)=>{
    console.log(`${valor} esta en el indice ${indice}`)
});

function recorridoArreglo(valor, indice, Yo){
    console.log(`${valor} esta en el indice ${indice}`)
}

Yo.forEach(recorridoArreglo);

console.log()

Yo.forEach((element, index)=> {
    console.log(`${element} is in the index ${index}`)
})

let recorrerArreglo = (element, index)=> {
    console.log(`${element} is in the index ${index}`);
};
Yo.forEach(recorrerArreglo);