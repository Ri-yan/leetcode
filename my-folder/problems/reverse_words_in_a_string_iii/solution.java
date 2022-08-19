class Solution {
    public String reverseWords(String s) {
        StringBuilder p = new StringBuilder(s);
        int st=0;int e=0;
        while(e<=p.length()-1 && st!=p.length()-1){
            if(p.charAt(e)!=' '){
                e++;
            }else if(p.charAt(e)==' '){
                reverse(p,st,e-1);
                e++;
                st=e;   
            }
            if(e==p.length()){
                reverse(p,st,e-1);
            }
        }
        return p.toString();
    }
    public void reverse(StringBuilder p,int i,int j){
        while(i<=j){
            char t=p.charAt(i);
            p.setCharAt(i,p.charAt(j));
            p.setCharAt(j,t);
            i++;j--;
        }}
}

        
    //     String[] strs = s.split(" ");
    // StringBuffer sb = new StringBuffer();
    // for(String str: strs){
    //     StringBuffer temp = new StringBuffer(str);
    //     sb.append(temp.reverse());
    //     sb.append(" ");
    // }
    // sb.setLength(sb.length()-1);
    // return sb.toString();
    

