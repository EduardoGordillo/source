package expresion;
public abstract class Expresion {
  abstract public void aceptar(VisitanteExpresion v);
}

package expresion;
public class Constante extends Expresion {
  public Constante(int valor) { _valor = valor; }
  public void aceptar(VisitanteExpresion v) { v.visitarConstante(this); }
  int _valor;
}

package expresion;
public class Variable extends Expresion {
  public Variable(String variable) { _variable = variable; }
  public void aceptar(VisitanteExpresion v) { v.visitarVariable(this); }
  String _variable;
}

package expresion;
public abstract class OpBinaria extends Expresion {
  public OpBinaria(Expresion izq, Expresion der) { _izq = izq; _der = der; }
  Expresion _izq, _der;
}
package expresion;
public class Suma extends OpBinaria {
  public Suma(Expresion izq, Expresion der) { super(izq, der); }
  public void aceptar(VisitanteExpresion v) { v.visitarSuma(this); }
}

package expresion;
public class Mult extends OpBinaria {
  public Mult(Expresion izq, Expresion der) { super(izq, der); }
  public void aceptar(VisitanteExpresion v) { v.visitarMult(this); }
}

/*
 * Esta es la clase abstracta que define la interfaz de los visitantes
 * de la jerarquía Expresion -- en realidad, utilizamos una interfaz Java
 * dado que todos los métodos son abstractos. 
 */

package expresion;
public interface VisitanteExpresion {
  public void visitarSuma(Suma s);
  public void visitarMult(Mult m);
  public void visitarVariable(Variable v);
  public void visitarConstante(Constante c);
}

/**
 * Uno de los posibles visitantes de las Expresiones es un pretty printer
 * que convierte a cadena de caracteres la expresión aritmética. El algoritmo
 * usado no optimiza el uso de paréntesis... El resultado se acumula en
 * el atributo privado _resultado, pudiéndose acceder a éste desde el exterior
 * mediante el método obtenerResultado()
 */

package expresion;
public class PrettyPrinterExpresion implements VisitanteExpresion {
  
  // visitar la variable en este caso es guardar en el resultado la variable
  // asociada al objeto... Observe que accedemos al estado interno del objeto
  // confiando en la visibilidad de paquete...
 
  public void visitarVariable(Variable v) { 
	_resultado = v._variable; 
  }

  public void visitarConstante(Constante c) {
	 _resultado = String.valueOf(c._valor); 
  }

  // Dado que el pretty-printer de una operación binaria es casi idéntica,
  // puedo factorizar parte del código con este método privado...

  private void visitarOpBinaria(OpBinaria op, String pOperacion) {
  	  op._izq.aceptar(this);
   	 String pIzq = obtenerResultado();

    	op._der.aceptar(this);
    	String pDer = obtenerResultado();

	_resultado = "(" + pIzq + pOperacion + pDer + ")";
  }

  // Por último la visita de la suma y la mult se resuelve mediante el método
  // privado que se acaba de mencionar...

 public void visitarSuma(Suma s) { 
	visitarOpBinaria(s, "+");
  }
  public void visitarMult(Mult m) { 
	visitarOpBinaria(m, "*"); 
  }

  // El resultado se almacena en un String privado. Se proporciona un método
  // de acceso público para que los clientes del visitante puedan acceder
  // al resultado de la visita

  public String obtenerResultado() { 
	return _resultado; 
   }
  private String _resultado;
}

import expresion.*;
class Main {
  static public void main(String argv[]) {
    // Construcción de una expresión (a+5)*(b+1)
    Expresion expresion = new Mult( new Suma( new Variable("a"),
                                              new Constante(5) ), 
                                    new Suma( new Variable("b"),
                                              new Constante(1) ));

     // Pretty-printing...
     PrettyPrinterExpresion pretty = new PrettyPrinterExpresion();
     expresion.aceptar(pretty);     

    // Visualizacion de resultados
    System.out.println("Resultado: " + pretty.obtenerResultado());
  }
}