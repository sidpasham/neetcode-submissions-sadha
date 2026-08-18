import heapq

class Solution:
    def findKthLargest(self, nums: List[int], k: int) -> int:

        min_heap = nums[:k]
        heapq.heapify(min_heap)

        for num in nums[k:]:
            if num > min_heap[0]:
                heapq.heappush(min_heap, num)
                heapq.heappop(min_heap)
        
        return min_heap[0]

            
        