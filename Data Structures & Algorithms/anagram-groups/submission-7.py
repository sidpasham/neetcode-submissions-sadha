class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        ## edgecase
        if not strs:
            return []
        
        key_map = defaultdict(list)

        for s in strs:
            key = "".join(sorted(s))
            key_map[key].append(s)
        
        return list(key_map.values())

        