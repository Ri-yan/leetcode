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
    public ListNode mergeTwoLists(ListNode list1, ListNode list2) {
        if(list1==null && list2==null){
            return null;
        }
        if (list1 == null) {
            return list2;
        }
        if (list2 == null) {
            return list1;
        }
        ListNode head;
        ListNode temp;
        ListNode h = null;
       List<Integer> s = new ArrayList<>();
        while(list1!=null){
            s.add(list1.val);
            list1=list1.next;
        }
         while(list2!=null){
            s.add(list2.val);
            list2=list2.next;
        }
        Collections.sort(s);
        //System.out.println(s);
        
       head=new ListNode (s.remove(0).intValue());
       //System.out.println(s);
        temp=head;
        for(Integer i : s){
            ListNode newNode=new ListNode(i.intValue());
            temp.next=newNode;
            temp=temp.next;
        }
        
        
        
        return head;
    }
}