bool continueSoftwareExecution = true;
while (continueSoftwareExecution == true)
{
    Console.WriteLine("do you wish to keep the sotfware runing? write 1 if yes, o if no");
    int KeepGoing = Convert.ToInt16(Console.ReadLine());
    if(KeepGoing == 1)
    {
        Console.WriteLine("hello world, forever");
        continueSoftwareExecution = true;
    }
    else if(KeepGoing == 0)
    {
        Console.WriteLine("this id the last time the software is running");
        continueSoftwareExecution = false;
    }
    else
    {
        Console.WriteLine("invalid input, try");
    }
        
}

bool whater = true;
while (whater == true)
{
    Console.WriteLine("usted tien sed? si(1) y no(3)");
    int boll = Convert.ToInt16(Console.ReadLine());
    if(boll == 1) 
    {
        Console.WriteLine("tome su agua");
        whater = true;
    }
    else if(boll == 3)
    {
        Console.WriteLine("bueno siga caminado");
        whater = false;
    }
    else
    {
        Console.WriteLine("coloque 1 o 3");
        Console.WriteLine("no coloque espacios por favor");
    }
}
