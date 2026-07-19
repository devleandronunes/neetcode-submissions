public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<List<int>> groups = new List<List<int>>();
        List<int> most_frequent = new List<int>();        
        int count = nums.Length;
        bool[] used = new bool[count];

        for (int i = 0; i < count; i++) {
            if (used[i]) continue;
            List<int> frequence = new List<int>();
            for (int j = i; j < count; j++) {
                if (nums[i] == nums[j]) {
                    frequence.Add(nums[j]);
                    used[j] = true;
                }
            }
            groups.Add(frequence);
        }
        
        groups.Sort((a, b) => b.Count.CompareTo(a.Count));

        for (int i = 0; i < k; i++) {
            most_frequent.Add(groups[i][0]);
        }

        int[] frequent_itens = new int[most_frequent.Count];
        for (int i = 0; i < most_frequent.Count; i++) {
            frequent_itens[i] = most_frequent[i];
        }
        return frequent_itens;
    }
}