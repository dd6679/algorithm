from collections import deque

def dfs(graph, v, visited):
    visited[v] = True
    print(v, end=' ')
    for i in graph[v]:
        if not visited[i]:
            dfs(graph, i, visited)


def bfs(graph, start, visited):
    queue = deque([start])
    visited[start] = True
    while queue:
        p = queue.popleft()
        print(p, end=' ')
        for i in graph[p]:
            if not visited[i]:
                queue.append(i)
                visited[i] = True


n, m, v = map(int, input().split())
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

d_graph = graph.copy()
b_graph = graph.copy()

d_visited = [False] * (n+1)
b_visited = [False] * (n+1)

dfs(d_graph, v, d_visited)
print()
bfs(b_graph, v, b_visited)
