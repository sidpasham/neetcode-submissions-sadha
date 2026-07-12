class Solution:

    def encode(self, strs: List[str]) -> str:
        encoded_str = ""
        if not strs:
            return encoded_str
    
        for s in strs:
            encoded_str += (f"{len(s)}#{s}")
        
        return encoded_str


    def decode(self, s: str) -> List[str]:
        if not s:
            return []
        
        i = 0
        result = []

        while i < len(s):
            j = i

            while s[j] != '#':
                j += 1
            
            length = int(s[i:j])

            start_word = j + 1
            end_word = start_word + length

            result.append(s[start_word:end_word])

            i = end_word
        
        return result
