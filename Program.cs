// Exceptions in C#

// Exceptions in catch parameter is built in class and superclass for all exceptions

using ConsoleApp20;

//try
//{
//    int res = div(0, 0);
//}
//catch (DivideByZeroException ex) when (ex.Source== "CAExceptions")
//{
//    // handling the exception in message or return value
//    Console.WriteLine("divided by zero");
//}
//finally  // it will apply when there's no exceptions 
//{
//    Console.WriteLine("end");
//}

















//try
//{
//    int res = div(2, 0);
//}
////catch (Exception ex) // in this situation must the father being in the last
////{
////    // handling the exception in message or return value
////    Console.WriteLine(ex.Message);
////}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally  // it will apply when there's no exceptions 
//{
//    Console.WriteLine("end");
//}

//try
//{
//    int res = div(2, 0);
//}
//catch (Exception ex)
//{
//    // handling the exception in message or return value
//    Console.WriteLine("divided by zero");
//}
//finally  // it will apply when there's no exceptions 
//{
//    Console.WriteLine("end");
//}
//try
//{
//    int res = div(2, 0);
//}
//catch
//{
//    Console.WriteLine("divided by zero");
//}
//finally
//{
//    Console.WriteLine("end");
//}

Delivery delivery = new Delivery {Id =123,CustomerName="mahmoud",Address="portsaid,alzohor" };
var service = new Delivery_Service();
service.Start(delivery);
//try             // Ducking or rethrowing
//{
//    service.Start(delivery);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
Console.WriteLine(delivery);

//static int div(int n1,int n2)
//{
//    return n1 / n2;
//}


