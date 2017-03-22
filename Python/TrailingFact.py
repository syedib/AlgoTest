def main():
    i = int(input())
    r5=len([x for x in range(1,i+1) if x%5==0])
    r25=len([x for x in range(1,i+1) if x%25==0])
    r125=len([x for x in range(1,i+1) if x%125==0])
    r625=len([x for x in range(1,i+1) if x%625==0])

    print r5+r25+r125+r625

if __name__ == "__main__":
    main()
