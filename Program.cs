using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reflector.Models;
using System.Reflection; //helps us to obtain meta data about methods and others.

namespace reflector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1, "Allen");
            showDetails(student);



        }
        //Assembly executing = Assembly.GetExecutingAssembly();

        //Type[] types = executing.GetTypes();
        //    foreach (string item in types)
        static void showDetails(object obj) //creating a function to print the length/Count of methods
            //Length of props
            //length of constructors
        {
            Type types = obj.GetType();
            Console.WriteLine( types.Name);
               MethodInfo[] methods =types.GetMethods(); //fetches all the methods and pushs in the array and prints the count

            Console.WriteLine($"No. of methods: {methods.Length}") ;

            PropertyInfo[] properties =types.GetProperties(); //fetches properties in array.


            Console.WriteLine($"No. of properties: {properties.Length}");

           ConstructorInfo[] constructors=types.GetConstructors() ;//fetches ctors and pushed into array
            Console.WriteLine($"no. of Constructors: {constructors.Length}");
        }
        }
}
