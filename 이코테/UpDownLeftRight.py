n = int(input())
data = list(map(str, input().split()))

dx = [0, -1, 0, 1]
dy = [1, 0, -1, 0]

x, y = 1, 1

for i in data:
    if i == 'R':
        index = 0
    if i == 'U':
        index = 1
    if i == 'L':
        index = 2
    if i == 'D':
        index = 3
    if 0 < x + dx[index] < n + 1 and 0 < y + dy[index] < n + 1:
        x += dx[index]
        y += dy[index]

print(x, y)
