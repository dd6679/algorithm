import sys
sys.setrecursionlimit(100000)

def dfs(x, y):
    if x <= -1 or x >= n or y <= -1 or y >= m:
        return False
    if graph[x][y] == '#':
        graph[x][y] = '0'
        dfs(x+1, y)
        dfs(x-1, y)
        dfs(x, y+1)
        dfs(x, y-1)
        return True
    return False


t = int(input())
for _ in range(t):
    n, m = map(int, input().split())
    graph = [list(input()) for _ in range(n)]
    count = 0
    for i in range(n):
        for j in range(m):
          # 양이 있을 때만 dfs 하도록해서 함수 적게 부르도록
            if graph[i][j] == '#' and dfs(i, j):
                count += 1
    # 문제 잘 읽기!!! - 각 테스트케이스마다 출력해달라고 함
    print(count)
