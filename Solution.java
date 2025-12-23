class Solution {
    public int maxProduct(int[] nums){
        int max = Math.max(nums[0], nums[1]);
        int max2 = Math.min(nums[0], nums[1]);
        for(int i = 2; i < nums.length; i++){
            if(max <= nums[i]){
                max2 = max;
                max = nums[i];
            }
            else{
                max2 = Math.max(max2, nums[i]);
            }
        }

        return((max - 1) * (max2 - 1));
    }
}
