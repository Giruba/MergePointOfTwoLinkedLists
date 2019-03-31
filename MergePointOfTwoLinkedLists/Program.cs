using System;

namespace MergePointOfTwoLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Point of Two Linked lists!");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("List1 Input-----------");
            LinkedList linkedList1 = GetLinkedListFromInput();
            Console.WriteLine("List2 Input-----------");
            LinkedList linkedList2 = GetLinkedListFromInput();
            try
            {
                if (linkedList1 == null || linkedList2 == null)
                {
                    Console.WriteLine("Merge point can't be found even if " +
                        " only of the Linkedlists is null!!");
                }
                if (linkedList1 != null && linkedList2 != null)
                {
                    LinkedListNode mergeNode =
                    linkedList1.GetMergePointOfTwoLinkedLists(
                            linkedList1.GetLinkedListHead(),
                            linkedList2.GetLinkedListHead());
                    if (mergeNode != null)
                    {
                        Console.WriteLine("The merge point is " +
                            " " + mergeNode.GetLinkedListData());
                    }
                    else
                    {
                        Console.WriteLine("There is no merge point between " +
                            " the two given lists");
                    }

                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is " +
                    " " + exception.Message);
            }


            Console.ReadLine();
        }

        private static LinkedList GetLinkedListFromInput() {
            LinkedList linkedList = null;

            Console.WriteLine("Enter the number of elements in " +
                "the list");
            try
            {
                int numberElements = int.Parse(Console.ReadLine());
                linkedList = new LinkedList();
                LinkedListNode linkedListNode = null;
                Console.WriteLine("Enter the elements separated by" +
                    " space");
                String[] elements = Console.ReadLine().Split(' ');
                for (int index = 0; index < numberElements; index++) {
                    linkedListNode = linkedList.Insert(linkedListNode, 
                        int.Parse(elements[index]));
                }
                linkedList.SetLinkedListHead(linkedListNode);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is " +
                    " "+exception.Message);
            }

            return linkedList;
        }
    }
}
