using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reflector.Models;
using System.Reflection;

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
        static void showDetails(object obj)
        {
            Type types = obj.GetType();
            Console.WriteLine("Class: {0}", types.Name);
               MethodInfo[] methods =types.GetMethods();

            Console.WriteLine("No. of Methods: {0}",methods.Length) ;

            PropertyInfo[] properties =types.GetProperties();


            Console.WriteLine("No. of Properties: {0}",properties.Length);

           ConstructorInfo[] constructors=types.GetConstructors() ;
            Console.WriteLine("no. of Constructors: {0}",   constructors.Length);
        }
    }
}
