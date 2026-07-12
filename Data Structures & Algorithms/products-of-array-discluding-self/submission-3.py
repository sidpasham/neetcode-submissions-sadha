class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        ## edgecases
        if not nums:
            return []
        
        result = [1 for num in range(len(nums))]
        
        pre = 1
        for i in range(len(nums)):
            result[i] = pre
            pre = pre * nums[i]
        
        post = 1
        for i in range(len(nums) - 1, -1, -1):
            result[i] = result[i] * post
            post = post * nums[i]
        
        return result

        
        