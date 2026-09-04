class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:

        seenS1 = {}
        seenS2 = {}
        l = 0

        for r in range(len(s1)):
            seenS1[s1[r]] = seenS1.get(s1[r],0) +1
    
        for r in range(len(s2)):
            seenS2[s2[r]] = seenS2.get(s2[r],0) +1
            window = r - l + 1

            if window > len(s1):
                seenS2[s2[l]] -= 1
                if seenS2[s2[l]] == 0:
                    del seenS2[s2[l]]
                l += 1
            
            if seenS1 == seenS2:
                return True
        return False

        


        