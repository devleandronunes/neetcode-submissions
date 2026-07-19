public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        List<int> result_list = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            List<int> nums_list = new List<int>(nums);
            int product = 1;
            nums_list.RemoveAt(i);
            foreach(var multiplicator in nums_list)
            {
                product *= multiplicator;
            }

            result_list.Add(product);
        }
        int[] result = result_list.ToArray();
        return result;
    }
}