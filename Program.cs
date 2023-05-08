namespace RecapOfTheDay
{
    internal class Program
    {
    
        static void Main(string[] args)
        {

      
            //Console.WriteLine(): used to display a line of text (output)
            Console.WriteLine(" My name is Zahra");
            Console.WriteLine("I am from Barka");
            
           // Console.Write(): used to display text on the same line (output).
            Console.WriteLine(" My name is Zahra");
            Console.Write("I am from Barka");
            
            // Console.ReadLine(): used to read an input.
            Console.ReadLine();
            
             Console.WriteLine("Hello,My name is Zahra Nasser Al Bulushi, i'm 25 years old from Barka. I'm a full stack developer which graduated from ATU which" +
            
            " based in Ireland with a Basholed digree of Since (Hounrs) in Computing in Software Development");
            
            
            
            string name = "Zahra", address = "Barka";
            int age = 25;
            int x = 20;
            
            // string Concatenation
            Console.WriteLine("Name: {0}, Age: {1}, from {2}", name, age, address);
            Console.WriteLine($"Name: {name}, Age: {age}, from {address}");

            
            //Value Type
            Console.WriteLine(age.GetHashCode);
            Console.WriteLine( x.GetHashCode);
            //Console.WriteLine(obj1.GetHashCode);
            //Console.WriteLine(obj2.GetHashCode);

            //Reference Type
            //Hood - create object  from Name class
            Name myObj1 = new Name();
            object obj1 = myObj1.employee_firstName;

            Name myObj2 = new Name();
            object obj2 = myObj2.employee_lastName;

           Console.WriteLine(obj1.GetHashCode);
           Console.WriteLine(obj2.GetHashCode);
 
            
           //var- data type can not be change, determined at compile time
            var xx = 3;
           // xx = "7";  
            Console.WriteLine(xx);  
            
            //dynamic- data type can be change, determined at runtime
            dynamic xxx = 4;
            xxx = "5"; // 
            Console.WriteLine(xxx);

           
            // Boolean return value of true or false

            //operators
            bool equal = x == xx; // false -- check if 2 values are equal
            bool notEqual = x != xx; // True -- check if 2 values are not equal
            bool graetrer = x > xx; // True -- greater than
            bool less = x < xx; // False -- less than
            bool graetrerOrequal = x >= xx; // True -- greater than or equal
            bool lessOrEqual = x <= xx; // False -- less than or equal

            //XOR ^
            Console.WriteLine(true ^ true);    // output: False 
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False
            
            // && -- and , both conditions must be true
            bool a = (9 > 99 && 0 < 9);  
            
            // || -- or , at least one condition is true
            bool o = (1 < 10 || 0 < 3); 
        }
    }
} 