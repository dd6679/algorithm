n, k = map(int, input().split())
count = 0
Ai = []

for i in range(n):
    Ai.append(input())
    Ai[i] = int(Ai[i])

Ai.reverse()

for i in Ai:
    count += k // i
    k %= i

print(count)
