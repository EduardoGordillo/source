// promocionar valores a tipo logico

console.log(Boolean(-0))
console.log(Boolean(0))
console.log(Boolean(1))
console.log(Boolean(-1))
console.log(Boolean(new Number(0))) // existencia de datos en memoria es true


console.log()

console.log(Boolean(true));
console.log(Boolean(false));
console.log(Boolean(null));
console.log(Boolean(undefined));


console.log()

console.log(Boolean(''));
console.log(Boolean(new String()));// existencia de datos en memoria es true

console.log();
console.log(Boolean('true'));
console.log(Boolean('false'));
console.log(Boolean('JavaScript es tremendo'));

console.log();

console.log(Boolean({}));
console.log(Boolean([]));

let fn = function(){
return 1
}

console.log(Boolean(fn()))