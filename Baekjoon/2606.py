def dfs(graph, v, visited):
    visited[v] = True
    #print(v, end=' ')
    for i in graph[v]:
        if not visited[i]:
            dfs(graph, i, visited)

n = int(input())
m = int(input())
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

dfs(graph, 1, visited)
# 1번 컴퓨터를 제외한 바이러스 걸린 컴퓨터의 수
print(visited.count(True)-1)
