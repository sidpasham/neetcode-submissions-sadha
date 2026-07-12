class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:

        if not strs:
            return []
        
        d = defaultdict(list)

        for s in strs:
            key = "".join(sorted(s))
            d[key].append(s)

        return list(d.values())

        