def sum(a,b):
    return a+b

def main():
    result = []

    noOfLines = int(raw_input())
   
    for i in range(noOfLines):
        a,b = raw_input().split()
        a=int(a)
        b=int(b)
        result.append(sum(a,b))

    for i in range(len(result)):
        print(result[i])
        

if __name__ == "__main__":
        main()
        
