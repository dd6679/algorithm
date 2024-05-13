def dfs(graph, v, visited):
    visited[v] = True
    # print(v, end=' ')
    for i in graph[v]:
        if not visited[i]:
            dfs(graph, i, visited)

            
result = 0

n, m = map(int, input().split())
edge = []
for i in range(m):
    l = list(map(int, input().split()))
    edge.append(l)

graph = [[] * 1 for _ in range(n+1)]

for i in edge:
    graph[i[0]].append(i[1])
    graph[i[1]].append(i[0])

for g in graph:
    g.sort()

visited = [False] * (n+1)

# 방문 여부가 false인 정점부터 dfs 시작
while False in visited[1:]:
    v = visited[1:]
    index = v.index(False)
    dfs(graph, index + 1, visited)
    result += 1

print(result)
