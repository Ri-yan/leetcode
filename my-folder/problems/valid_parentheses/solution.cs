public class Solution {
    public bool IsValid(string s) {
        Stack<char> x = new Stack<char>();
        for(int i=0;i<s.Length;i++){
             switch(s[i]){
            case '{' :
            case '[' : 
            case '(' : x.Push(s[i]);
            break;
            case ')':
                    if (x.Count == 0 || x.Pop() != '(') return false;
                    break;
                case '}':
                    if (x.Count == 0 || x.Pop() != '{') return false;
                    break;
                case ']':
                    if (x.Count == 0 || x.Pop() != '[') return false;
                    break;
        }
        }
       return x.Count ==0;
    }
}