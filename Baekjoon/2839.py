n = int(input())
count = 0


def SugarDeli(num, c):
    if num % 5 == 0:
        c += num // 5
        print(c)
    elif num < 0:
        print(-1)
    else:
        num = num - 3
        c += 1
        SugarDeli(num, c)


SugarDeli(n, count)
