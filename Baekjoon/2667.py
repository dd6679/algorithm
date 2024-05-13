count = 0
def dfs(x, y):
    if x <= -1 or x >= n or y <= -1 or y >= n:
        return 0
    if graph[x][y] == 1:
        graph[x][y] = 9
        # 전역 변수 사용하기 위해 명시
        global count
        count += 1
        dfs(x-1, y)
        dfs(x+1, y)
        dfs(x, y-1)
        dfs(x, y+1)
        return count
    return 0


n = int(input())

graph = [list(map(int, input())) for _ in range(n)]

result = 0
house_count = []
for i in range(n):
    for j in range(n):
        count = dfs(i, j)
        if count > 0:
            result += 1
            house_count.append(count)

print(result)
house_count.sort()
# *을 이용해 unpack 한 데이터를 구분자 sep를 이용해 리스트 요소를 한줄씩 출력
print(*house_count, sep='\n')
