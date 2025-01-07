using System.Reflection;
using System.Threading.Channels;

namespace Assignment_04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "C:\\Users\\rushi\\OneDrive\\Desktop\\D_Data\\PG-DAC\\Github Data\\PrepatoryAssignments\\C#.net\\Assignment_04_\\MathsLib\\bin\\Debug\\net8.0\\MathsLib.dll\"
            string path = "C:\\Users\\rushi\\OneDrive\\Desktop\\D_Data\\PG-DAC\\Github Data\\PrepatoryAssignments\\C#.net\\Assignment_04_\\MathsLib\\bin\\Debug\\net8.0\\MathsLib.dll";

            Assembly assembly = Assembly.LoadFrom(path);

           Type [] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine(type.FullName);
                //object creation of that class
                object dynamicallyCreated = assembly.CreateInstance(type.FullName);

                //get the methods list 
                MethodInfo [] methods = type.GetMethods();

                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine(method.Name);

                    //get the parameters
                    ParameterInfo[] par = method.GetParameters();

                    object [] parameterToMethod = new object[par.Length];

                    for(int i = 0; i < parameterToMethod.Length; i++)
                    {
                        Console.WriteLine("Enter value for {0} of type {1} ", par[i].Name, par[i].ParameterType );

                        // take the input value from user
                        string parameteValueString = Console.ReadLine();


                        object parameter = Convert.ChangeType(parameteValueString, par[i].ParameterType);

                        parameterToMethod[i] = parameter;

                        object output = type.InvokeMember(method.Name,BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,null,dynamicallyCreated,parameterToMethod);

                        Console.WriteLine(method.Name ,output);


                    }
                }

                
            }

            Console.ReadLine();



        }
    }
}
