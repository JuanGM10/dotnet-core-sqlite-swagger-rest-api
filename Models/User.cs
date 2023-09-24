using System;
namespace Backend.Models
{
    public class User{
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set;}
    }

    public class Calculator
    {
        public int Id { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Operation { get; set; }
        public int Result { get; set; }
    }
}
