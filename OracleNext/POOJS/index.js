class Cliente {
    constructor(nombreCliente,dniCliente){
    this.nombre= nombreCliente;
    this.dni = dniCliente;
   
        }

    }
class Cuenta {
    

    constructor(numero){
        this.numero = numero;
        this.saldo = 0;
    }
    depositoCuenta(valor)
    {
        this.saldo += valor;
    }
    retirarCuenta(valor){
        if(this.saldo < valor){
            console.log('Fondos insuficientes')
        }
        else{
            this.saldo -= valor;
        }
    }

}

const Jose = new Cliente('José', '1641');
const cuentaJose = new Cuenta('19498');
console.log(Jose, cuentaJose);

cuentaJose.depositoCuenta(100);
console.log(cuentaJose);
cuentaJose.retirarCuenta(1000);
console.log(cuentaJose);