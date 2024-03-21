using System.Collections;

namespace Csharp {
    public class CreateArrayList {
        static void Main(string[] args) {
            ArrayList al = new ArrayList();
            // or
            var al2 = new ArrayList();  // recommended
        }
    }
}
/*
  Now, Why 'var' is recommended?
    Because, it is a type inference. It means that the compiler will automatically determine the type 
    of the variable based on the value assigned to it.
    So, you don't have to explicitly mention the type of the variable.

     For example, in the above code, the compiler will automatically determine that the 
     type of the variable 'al2' is ArrayList.
*/