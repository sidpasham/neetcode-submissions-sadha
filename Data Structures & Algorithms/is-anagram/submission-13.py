class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        s_counts = {}
        for c in s:
            s_counts[c] = s_counts.get(c, 0) + 1

        t_counts = {}
        for c in t:
            t_counts[c] = t_counts.get(c, 0) + 1
        
        for c in s:
            if s_counts[c] != t_counts.get(c, 0):
                return False
        
        return True
        

        