import math

if __name__ == "__main__":

    arrayLength = int(raw_input())
    
    a = list(map(int,raw_input().split()))
    if arrayLength == len(a):
        print(sum(a))

