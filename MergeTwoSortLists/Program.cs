using System;

ListNode list1 = new ListNode(1);
list1.next=new ListNode(2);
list1.next.next = new ListNode(4);

ListNode list2 = new ListNode(1);
list2.next=new ListNode(3);
list2.next.next = new ListNode(4);

ListNode list3 = MergeTwoLists( list1,  list2);
while(list3 != null)
{
    Console.WriteLine(list3.val);
    list3 = list3.next;
}
static ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    if(list1==null) return list2 ;
    if(list2==null) return list1 ;
    ListNode list3=new ListNode();
    ListNode list4 = list3;
    while (list1 != null && list2 != null)
    {
        if (list1.val <= list2.val)
        {
               list3.val = list1.val;
               list1 = list1.next;
        }
        else {
                list3.val=list2.val;
                list2 = list2.next;
        }
        if(list1 != null && list2 != null)
        { 
            list3.next = new ListNode();
            list3 = list3.next;
        }
    }
    if (list2 != null)
    {
        list3.next = list2;
    }
    else
    if (list1 != null)
    {
        list3.next = list1;
     
    }
    return list4;
}
public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
 }

