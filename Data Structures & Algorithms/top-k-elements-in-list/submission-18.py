class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        ## edgecase
        if not nums:
            return []

        counts = {}

        for num in nums:
            counts[num] = counts.get(num, 0) + 1
        
        freq = [[] for i in range(len(nums) + 1)]

        for num, count in counts.items():
            freq[count].append(num)
        
        result = []
        for i in range(len(freq) - 1, 0, -1):
            for n in freq[i]:
                result.append(n)

                if len(result) == k:
                    return result
        
        return []


        

        