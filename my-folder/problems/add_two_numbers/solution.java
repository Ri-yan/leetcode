/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {        
        ListNode head = new ListNode(); //new list
        ListNode temp=head;
        int c=0; //carry
        while(l1!=null || l2!=null || c!=0){
            int v1=(l1!=null) ?v1=l1.val:0;  //setting 0 if l1 ends or it is shoty
            int v2=(l2!=null) ?v2=l2.val:0;  // ''    ''      ''
            int v3=v1+v2+c; // calculating digit
            c=v3/10; // taking carry out
            v3=v3%10; //removing carry digit
            temp.next=new ListNode(v3); // adding in new list
            temp=temp.next;  //incrementing new list
            l1=(l1!=null)?l1.next:null; // setting list null if it is short
            l2=(l2!=null)?l2.next:null; //    ,,      ,,        ,,
        }
        return head.next;
    }
}