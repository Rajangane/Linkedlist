// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************** Welcome To Linkedlist***************");
using Linkedlist;
Console.Write("Select Number:\n1)Add elements");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        Linked_List<int> list = new Linked_List<int>();//creating list

        list.Add(56);
        list.Add(30);
        list.Add(70);
        Console.WriteLine("Linked list elements are:");
        list.Display();
        break;
}
        
