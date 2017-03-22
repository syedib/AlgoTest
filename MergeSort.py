def Merge(A):
    p = 0
    r = len(A)
    q = int(r/2)

##    print("p: ",p)
##    print("r: ",r)
##    print("q: ",q)
    
    n1 = q-p+1
    n2 = r-q

##    print(n1,n2)
    
    A1 = [A[i] for i in range(p,q+1)]
    A2 = [A[i] for i in range(q+1,r)]
    i = 0
    j = 0
    print(A1,A2)
    for k in range(len(A)):
        if A1[i] < A2[j]:
##            A[k] = A1[i]
            print("i: ",i)
            i = i + 1
        else:
##            A[k] = A2[j]
            print("j: ",j)
            j = j + 1
    return A

    

if __name__ == "__main__":
    print(Merge([2,3,6,5,9,8,11,10,12,22,21,23]))
