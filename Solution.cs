public class Solution {
    public int MaxProduct(int[] nums) {
        int max = Math.Max(nums[0], nums[1]);
        int max2 = Math.Min(nums[0], nums[1]);
        for(int i = 2; i < nums.Length; i++){
            if(max <= nums[i]){
                max2 = max;
                max = nums[i];
            }
            else{
                max2 = Math.Max(max2, nums[i]);
            }
        }

        return((max - 1) * (max2 - 1));
    }
}
