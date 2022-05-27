function funcion1(){
    var a =2;
    function funcion3(){
        var b = 5;
        function funcion5(){
            console.log(a,b);
        }
    }

}

function funcion2(){
    var a = 5;
    function funcion4(){
        b =6
    } 
}

funcion1();
funcion2();
//console.log(a); ReferenceError
