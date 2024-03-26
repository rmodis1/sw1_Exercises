using System;

namespace Products
{
    /// <summary>
    /// Creates a dog leash class that inherits from Product
    /// </summary>
  
    class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }
    }
}

