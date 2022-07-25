// usar el ciclo while para recorrer un arreglo

let lenguajes = ['JavaScript', 'C#', 'PHP', 'Java', 'Python'];

let i = 0;
while(i < lenguajes.length){
    console.log(`${lenguajes[i]} esta en el indice ${lenguajes.indexOf(lenguajes[i])}`);
    ++i;
};
