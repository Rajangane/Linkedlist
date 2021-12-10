// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************** Welcome To Linkedlist***************");
using Linkedlist;
Console.Write("Select Number:\n1)Add elements\n2)Append\n3)Insert\n4)RemoveFirstElement\n5)RemoveLastElement\n6)Search\n7)Insert40");
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
    case 3:
        list.Add(56);
        list.Insert(2, 30);
        list.Add(70);
        list.Display();
        break;
    case 4:
        list.Add(56);
        list.Add(30);
        list.Add(70);
        list.RemoveFirst();
        Console.WriteLine("\nFirst Element Removed\n");
        list.Display();
        break;
    case 5:
        list.Add(56);
        list.Add(30);
        list.Add(70);
        list.RemoveLast();
        Console.WriteLine("\nLast Element Removed\n");
        list.Display();
        break;
    case 6:
        list.Add(56);
        list.Add(30);
        list.Add(70);
        Console.WriteLine(list.Search(30));
        break;
    case 7:
        list.Add(56);
        list.Add(30);
        list.Add(70);
        list.Insert(3, 40);//in the position of 3 insert 40
        Console.WriteLine("Linked list elements after inserting :");
        list.Display();
        break;

    default:
        Console.WriteLine("invalid option");
        break;
}

        
