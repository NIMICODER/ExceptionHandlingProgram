namespace ExceptionHandlingProgram
{
    internal class Program
    {
        
        static void CheckAge(int age)
        {
            if(age < 18)
            {
                throw new ArgumentException("Access denied - you must be at least 18 years old.");

            } else
            {
                throw new ArgumentException("Access granted -  you are old enough");
            }
        }
        static void Main(string[] args)
        { 
            try
            {

           
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result: {num1 / num2}");
            }
            catch(DivideByZeroException e)
            { 
            
                Console.WriteLine(e.Message);   
            }
            catch (FormatException e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

            try
            {

            //SystemException constructor
            int[] myNum = { 1, 2, 3 };
            Console.WriteLine(myNum[10]);


            } catch(Exception e)
            {
                Console.WriteLine("Something went wrong");    
            }
            finally
            {
                Console.WriteLine("The 'try catch' block has finished running");
            }

            CheckAge(19);

            //Exception Exception(SerializationInfo, StreamingContext) initializes a new instance of the Exception class with serialized data.
            try
            {


            } 
            catch
            {

            }
        }
    }
}