import {Cliente} from "./Cliente.js";
import {Cuenta} from "./Cuenta.js";


const Jose = new Cliente('José', '1641');

const cuentaJose = new Cuenta(19498);
cuentaJose.cliente = Jose;
const Daniel = new Cliente('Daniel', '195198');
const cuentaDaniel = new Cuenta();
console.log(cuentaJose);
cuentaJose.depositoCuenta(10000);
cuentaDaniel.depositoCuenta(100);
cuentaJose.retirarCuenta(1000);

var saldoJo = cuentaJose.consultaSaldo();
console.log(saldoJo);