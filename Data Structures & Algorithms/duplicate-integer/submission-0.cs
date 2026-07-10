public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> duplicate = new HashSet<int>();
        foreach(var num in nums) {
            if(!duplicate.Add(num)){
                return true;
            }
        }
        return false;
    }
}