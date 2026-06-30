from math import ceil

class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        left, right = 1, max(piles)

        result = right

        def canEat(speed):
            total_hours = 0
            for pile in piles:
                total_hours += ceil(pile / speed)
            return total_hours <= h

        while left <= right:
            mid = (left + right) // 2
            if(canEat(mid)):
                result = mid
                right = mid -1
            else:
                left = mid + 1
        return result