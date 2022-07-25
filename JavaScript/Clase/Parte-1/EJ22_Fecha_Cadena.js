let cadenaFecha = 'May 13, 1913 13:17:19'

let fecha = new Date(cadenaFecha);

console.log(fecha);

fecha.setMonth(0);
console.log(fecha);

// Crear fecha a partir del estandar RDC 3339
cadenaFecha = '1913-05-13T13:17:19.23Z';
fecha = new Date(cadenaFecha);

console.log(fecha);