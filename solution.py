class Solution:
    def maxProduct(self, nums):
        m1 = max(nums[0], nums[1])
        m2 = min(nums[0], nums[1])
        for i in range(2, len(nums)):
            if m1 <= nums[i]:
                m2 = m1
                m1 = nums[i]
            else:
                m2 = max(m2, nums[i])

        return (m1 - 1) * (m2 - 1)
