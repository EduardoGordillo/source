// Consultar las representaciones validas de valores logicos

 if(0){
     console.log('El valor de 0 es true')
 }else{
     console.log('El valor de 0 es false')
 }
 if(-0){
    console.log('El valor de -0 es true')
}else{
    console.log('El valor de -0 es false')
}

if(null){
    console.log('El valor de `null` es true')
}else{
    console.log('El valor de `null` es false')
}
if(false){
    console.log('El valor de false es true');
}else {
    console.log('El valor de false es false')
}

if(NaN){
    console.log('El valor de NaN es true')
}else{
    console.log('El valor de NaN es false')
}

if(undefined){
    console.log('El valor de undefined es true')
}else{
    console.log('El valor de undefined es false')
}
if(''){
    console.log('El valor de `` es true')
}else{
    console.log('El valor de `` es false')
}
if(1){
    console.log('El valor de 1 es true')
}else{
    console.log('El valor de 1 es false')
}
if(-1){
    console.log('El valor de -1 es true')
}else{
    console.log('El valor de -1 es false')
}

let objeto = {};

if(objeto){
    console.log('El valor de objeto es true')
}else{
    console.log('El valor de objeto es false')
}

let sumar = (a,b)=> {return a+b};
if(sumar(4,5)){
    console.log('La funcion sumar es true')
}else{
    console.log('La funcion sumar es false')
}