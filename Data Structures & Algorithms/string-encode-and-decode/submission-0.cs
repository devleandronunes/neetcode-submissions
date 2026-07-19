public class Solution {
    public string Encode(IList<string> strs) {
        string strs_encode = "";
        int count = strs.Count;

        for (int i = 0; i < count; i++) {
            strs_encode += strs[i].Length + "#" + strs[i];
        }

        return strs_encode;
    }

    public List<string> Decode(string s) {
        List<string> strs_decode = new List<string>();
        int i = 0;

        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            string content = s.Substring(j + 1, length);
            strs_decode.Add(content);
            i = j + 1 + length;
        }

        return strs_decode;
    }
}