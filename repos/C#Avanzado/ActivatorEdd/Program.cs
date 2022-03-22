using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ActivatorEdd
{
    

        public class SomeType
        {
            public void DoSomething(int x)
            {
                Console.WriteLine("100 / {0} = {1}", x, 100 / x);
            }
        }

        public class ExampleEdd
        {
            static void Main()
            {
                // creamos una instancia de StringBuilder usando typeof
                // 
                // Activator.CreateInstance.
                Object o = Activator.CreateInstance(typeof(StringBuilder));
            
                // 
                // Append a string into the StringBuilder object and display the
                // StringBuilder.
                StringBuilder sb = (StringBuilder)o;
                sb.Append("Hola a todos");
                Console.WriteLine(sb);

                // Create an instance of the SomeType class that is defined in this
                // assembly.
                System.Runtime.Remoting.ObjectHandle oh =
                    Activator.CreateInstanceFrom(Assembly.GetEntryAssembly().CodeBase,
                                                 typeof(SomeType).FullName);

                // Call an instance method defined by the SomeType type using this object.
                SomeType st = (SomeType)oh.Unwrap();

                st.DoSomething(5);
            }
        }

    
}

