const Calculadora = {

    add: function (x, y) {
        return x + y;
    },

    substract: function (x, y) {
        return x - y;
    },
    multiply: function (x, y) {
        return x * y;
    },
    divide: function (x, y) {

        if (y === 0) {
            console.log('No se puede dividir entre 0');
        } else { return x / y; }


    }

};
module.exports = Calculadora;
