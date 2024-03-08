// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Double p1, p2, p3, p4;


   

Console.Write("p1: ");
p1 = Convert.ToDouble(Console.ReadLine());

Console.Write("p2: ");
p2 = Convert.ToDouble(Console.ReadLine());

Console.Write("p3: ");
p3 = Convert.ToDouble(Console.ReadLine());

Console.Write("p4: ");
p4 = Convert.ToDouble(Console.ReadLine());

Double Promedio = (p1+p2+p3+p4)/4;

if (Promedio >= 70)

{
    Console.WriteLine("Paso puede descansar en paz");
}

else
{
   
    Console.WriteLine("No paso");
}