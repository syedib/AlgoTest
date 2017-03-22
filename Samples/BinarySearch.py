import math
def binarySearch(List,t):
    low = 1
    high = len(List)

    mid = 1 + (high - low)/2
    
    while mid<high:
        
        if List[int(math.ceil(mid))]==t:
            return mid
        elif List[int(math.ceil(mid))] > t:
            mid = mid-1
        elif List[int(math.ceil(mid))] < t:
            mid = mid+1
        else:
            return None
if __name__ == "__main__":
    print(binarySearch([3,4,5,6,7,8,9],8))
