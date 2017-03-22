import timeit
def insertionSort(A):
    time_start = timeit.default_timer()

    for i in range(1,len(A)):
        k=A[i]
        j=i-1
        while j>0 and A[j]>k:
            A[j+1]=A[j]
            j=j-1
        A[j+1]=k

    time_end = timeit.default_timer()

    return A,time_end-time_start
            

if __name__ == "__main__":
    A = list(map(int,raw_input().split(',')))
    ##print(A)
    print(insertionSort(A))
