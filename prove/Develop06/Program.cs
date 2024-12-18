using System;

class Program
{
    static void Main(string[] args)
    {
        Activity atividade1 = new Activity("Ola", "teste", 10);
        atividade1.DisplayStartingMessage();
        atividade1.DisplayEndingMessage();

    
    }
}