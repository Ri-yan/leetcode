/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null || headB == null) return null;

        // Dictionary<ListNode, bool> hash = new Dictionary<ListNode, bool>();

        // while (headA != null) {
        //     hash[headA] = true; 
        //     headA = headA.next;
        // }

        // while (headB != null) {
        //     if (hash.ContainsKey(headB)) {
        //         return headB; 
        //     }
        //     headB = headB.next;
        // }

        // return null; 

        var t1 = headA;
        var t2 = headB;
        while(t1!=t2){
            if(t1==null && t2==null) return null;
            t1 = (t1==null)?headB:t1=t1.next;
            t2 = (t2==null)?headA:t2=t2.next;
            
        }
        return t1;
    }
}