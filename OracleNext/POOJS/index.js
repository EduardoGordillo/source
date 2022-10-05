import {Cliente} from "./Cliente.js";
import {Cuenta} from "./Cuenta.js";


const Jose = new Cliente('José', '1641');

const cuentaJose = new Cuenta(Jose, Cuenta.cantidadCuentas+1);

console.log(cuentaJose, cuentaJose.cliente);

const Daniel = new Cliente('Daniel', '1845');
const cuentaDaniel = new Cuenta(Daniel, Cuenta.cantidadCuentas+1);
console.log(cuentaDaniel, cuentaDaniel.cliente)

console.log(Cuenta.cantidadCuentas)