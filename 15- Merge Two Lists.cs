public class ListNode
{
    public int Value;
    public ListNode Next;

    public ListNode(int value = 0, ListNode next = null!)
    {
        this.Value = value;
        this.Next = next;
    }

    public static ListNode MergeSortedLists(ListNode firstList, ListNode secondList)
    {
        var resultHead = new ListNode();
        var currentNode = resultHead;

        while (firstList != null && secondList != null)
        {
            if (firstList.Value <= secondList.Value)
            {
                currentNode.Next = firstList;
                firstList = firstList.Next;
            }
            else
            {
                currentNode.Next = secondList;
                secondList = secondList.Next;
            }
            currentNode = currentNode.Next;
        }

        if (firstList != null)
        {
            currentNode.Next = firstList;
        }
        else if (secondList != null)
        {
            currentNode.Next = secondList;
        }

        return resultHead.Next; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        var list1 = new ListNode(1, new ListNode(3, new ListNode(5)));
        var list2 = new ListNode(2, new ListNode(4, new ListNode(6)));

        var mergedList = ListNode.MergeSortedLists(list1, list2);

        var currentNode = mergedList;
        while (currentNode != null)
        {
            Console.Write(currentNode.Value + " ");
            currentNode = currentNode.Next;
        }
    }
}
