class Solution {
    public int uniqueMorseRepresentations(String[] words) {
        final String morse[]={".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
                Set<String> x =new HashSet<>();               
        for(String word:words){
            StringBuilder S = new StringBuilder();
              for(char c:word.toCharArray()) {
                  S.append(morse[c-'a']);
              } 
            x.add(S.toString());           
        }
           return x.size();                    
    }
}