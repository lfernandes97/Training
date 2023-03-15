
string[] numbers = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach ( string i in numbers)
{
    
    if (i.StartsWith("B"))
    {  
        Console.WriteLine(i);
    }
    
;}

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}