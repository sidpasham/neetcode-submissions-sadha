class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        if not nums:
            return False
        
        hs = set()
        
        for num in nums:
            if num in hs:
                return True
            hs.add(num)
        
        return False

        