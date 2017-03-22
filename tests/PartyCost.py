def main():
    T = int(input())
    for k in range(T):
        N,X = raw_input().split(' ')
        ele = [None]*int(N)
        for i in range(int(N)):
            ele[i]=int(input())

        index = 0
        bFound = bool(0)
        while index<=len(ele) and bFound == False:
            Sum = 0
            for i in range(index,len(ele)):
                    Sum += ele[i]
                    if Sum == int(X):
                        bFound = True
                               
            index += 1

        if bFound == True:
            print "YES"
        else:
            print "NO"
if __name__ == "__main__":
    main()
