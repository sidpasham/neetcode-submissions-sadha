class Solution:
    def maxSlidingWindow(self, nums: List[int], k: int) -> List[int]:

        output = []
        q = deque()
        l = 0
        r = 0

        while r < len(nums):
            ## if item is less, then remove to create monotonic decreasing queue
            while q and nums[q[-1]] < nums[r]:
                q.pop()
            
            q.append(r)

            if l > q[0]:
                q.popleft()

            ## I'm going out of boundary, append to output
            if(r + 1) >= k:
                output.append(nums[q[0]])
                l = l + 1

            ## increase the right boundary
            r = r + 1
        return output



        