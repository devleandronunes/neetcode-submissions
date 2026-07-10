public class Solution {
    public bool IsAnagram(string s, string t) {
        List<string> anagram = new List<string>{s, t};
        for(int i = 0; i < anagram.Count; i++) {  
            string word = anagram[i];                      
            string order_word = string.Concat(word.OrderBy(w => w));
            anagram[i] = order_word;
        }
        if(anagram[0] == anagram[1]) {
            return true;
        } else {
            return false;
        }
    }
}
