public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<string> words = new List<string>(strs);
        List<string> order_words = new List<string>(strs);
        List<List<string>> anagrams = new List<List<string>>();
        bool[] used = new bool[words.Count];

        for (int i = 0; i < words.Count; i++) {
            string word = words[i];
            order_words[i] = string.Concat(word.OrderBy(w => w));
        }

        for (int i = 0; i < words.Count; i++) {
            if (used[i]) continue;
            List<string> words_list = new List<string>();
            for (int j = i; j < words.Count; j++) {
                if (order_words[i] == order_words[j]) {
                    words_list.Add(words[j]);
                    used[j] = true;
                }
            }
            anagrams.Add(words_list);
        }

        return anagrams;
    }
}