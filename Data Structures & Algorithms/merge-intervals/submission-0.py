class Solution:
    def merge(self, intervals: List[List[int]]) -> List[List[int]]:
        # edgecases
        if len(intervals) == 0:
            return None
        
        intervals.sort(key= lambda x: x[0])

        output = [intervals[0]]

        for start, end in intervals[1:]:
            lastEnd = output[-1][1]

            if start <= lastEnd:
                output[-1][1] = max(lastEnd, end)
            else:
                output.append([start, end])
        return output