
export class Cuenta {
    
    cliente;
    numero;
    #saldo;
    constructor(saldo){
        this.cliente = null;
        this.numero = '';
        this.#saldo = saldo || 0;
    }
    depositoCuenta(valor)
    {
        if(valor < 0){
            console.log('Numero invalido');
        }
        else{
            return this.#saldo += valor;
            
        }
    }
    retirarCuenta(valor){
        if(this.#saldo < valor){
            console.log('Fondos insuficientes')
        }
        else{
            return this.#saldo -= valor;
            
        }
    }
    consultaSaldo(){
        return this.#saldo;
    }

}