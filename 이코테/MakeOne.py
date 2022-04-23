x = int(input())
count = [0] * 10 * x
count[0] = 0
count[1] = 0

for i in range(2, x + 1):
    count[i] = count[i-1] + 1
    if i % 5 == 0:
        count[i] = min(count[i], count[i//5] + 1)
    if i % 3 == 0:
        count[i] = min(count[i], count[i//3] + 1)
    if i % 2 == 0:
        count[i] = min(count[i], count[i//2] + 1)

print(count[x])
