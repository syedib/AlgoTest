def isClassCancelled():

    T = int(input())
    for i in range(T):
        N = list(map(int,raw_input().split()))
        a = list(map(int,raw_input().split()))
        if len(a) == N[0] and N[0]>=N[1]:
            if (len([x for x in a if x <= 0]) >= N[1]) == False:
                print("YES")
            else:
                print("NO")
        else:
            print("Invalid")
    
if __name__ == "__main__":
    isClassCancelled()
