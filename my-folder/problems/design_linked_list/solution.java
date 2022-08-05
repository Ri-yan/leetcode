class MyLinkedList {
    class Node{
        int val;
        Node next;
        public Node(int val){
            this.val=val;
        }
    }
    Node head;
    int size;
    public MyLinkedList() {
        size=0;
        head=null;
    }
    
    public int get(int index) {
        if(index>=0 && index<size){
            Node temp=head;
            while(index>0){
                temp=temp.next;
                index--;
            }
            
           return temp.val;
        }else{
             return -1;
        }
       
    }
    
    public void addAtHead(int val) {
        Node newnode= new Node(val);
       newnode.next = head;
       head = newnode;  
        size++;
    }
    
    public void addAtTail(int val) {
       Node newnode = new Node(val);
       size++;
       if(head==null){
          head = newnode;
       }else{
          Node cur = head;
          while(cur.next!=null){
           cur = cur.next;
           }
          cur.next = newnode;
       }
    }
    
    public void addAtIndex(int index, int val) {
       if(index>size) return;
       if(index<0) {
           addAtHead(val);
           size++;
       }
       else{
           Node dmy = new Node(-1);
           dmy.next = head;
           Node cur = dmy;
           while(index>0)
           {
               cur = cur.next;
               index--;
           }
           Node newnode = new Node(val);
           Node temp = cur.next;
           cur.next = newnode;
           newnode.next = temp;
           head = dmy.next;
           size++;
    }
    }
    public void deleteAtIndex(int index) {
       if(index<size&&index>=0){
           size--;
           Node dmy = new Node(0);
           dmy.next = head;
           Node cur = dmy;
           while(index>0){
               cur = cur.next;
               index--;
           }
           cur.next = cur.next.next;
           head = dmy.next;
       }
       else return;
   }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.get(index);
 * obj.addAtHead(val);
 * obj.addAtTail(val);
 * obj.addAtIndex(index,val);
 * obj.deleteAtIndex(index);
 */