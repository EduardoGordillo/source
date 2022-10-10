export class Empleado {
    #nombre;
    #dni;
    #salario;
    #clave;
    constructor(nombre, dni, salario){
        this.#nombre = nombre;;
        this.#dni = dni;
        this.#salario = salario;
        this.#clave = ''

    }
    asignarClave(clave){
        this.#clave = clave;
    } 

    autenticable(clave){
        return clave == this.#clave;
    }
    _verBonificacion(){

        return this.salario;
        //throw new Error('Cada hijo debe implementar el metodo de la clase')
    }
    _verBonificacion(bono){
        return this.#salario + this.#salario*(bono/100);
    }
}