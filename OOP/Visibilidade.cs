using System;

namespace C__Examples {
  class Visibilidade {
    // public - the member can be reached from anywhere. 
    //    This is the least restrictive visibility. 
    //    Enums and interfaces are, by default, publicly visible.

    // protected - members can only be reached from within the same class, 
    //    or from a class which inherits from this class.

    // internal - members can be reached from within the same project only.

    // protected internal - the same as internal, 
    //    except that classes which inherit from this class can reach its members; 
    //    even from another project.

    // private - can only be reached by members from the same class. 
    //    This is the most restrictive visibility. 
    //    Classes and structs are by default set to private visibility.
  }
}