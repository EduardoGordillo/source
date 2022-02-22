var marcaCoches = ["Ford", "Seat", "Mercedes", "Porsch", "BMW","Ferrari"];

console.log(marcaCoches[0]);

marcaCoches[2] = ["Toledo", "Ibiza", "Leon"];
    
console.log(marcaCoches[2]);
console.log(marcaCoches[2].length);
var Ford = marcaCoches.shift();
console.log(Ford);
var Ferrari = marcaCoches.pop();
console.log(marcaCoches, Ferrari);
marcaCoches.push("Sabado");
console.log(marcaCoches);
marcaCoches.splice(1, 0, "Mustang");
console.log(marcaCoches);
marcaCoches.splice(5,1);
console.log(marcaCoches);
var BMW = marcaCoches.splice(4, 1, "Mazerati");
console.log(BMW);


