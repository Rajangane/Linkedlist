// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************** Welcome To Linkedlist***************");
using Linkedlist;
Console.Write("Select Number:\n1)Add elements\n2)Append");
int option = Convert.ToInt32(Console.ReadLine());
Linked_List<int> list = new Linked_List<int>();//creating list
switch (option)
{
    case 1:
        

        list.Add(56);
        list.Add(30);
        list.Add(70);
        Console.WriteLine("Linked list elements are:");
        list.Display();
        break;
    case 2:

        list.Append(56);
        list.Append(30);
        list.Append(70);
        Console.WriteLine("Linked list elements are:");
        list.Display();
        break;
}

        
