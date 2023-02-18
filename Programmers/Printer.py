from collections import deque

def solution(priorities, location):
    answer = 0
    # 중요도가 높은 순서대로 문서를 인쇄
    # 인쇄 대기 목록 가장 앞에 있는 문서를 대기목록에서 꺼낸 후
    # 첫번째 문서보다 중요도가 높은 문서가 한 개라도 있으면 첫번째 문서를 가장 마지막으로 보내기
    queue = deque()
    priorities_dict = {}
    prints = []
    for i in range(len(priorities)):
        queue.append(i)
        priorities_dict[i] = priorities[i]
        
    while len(prints) < len(priorities_dict):
        current = queue.popleft()
        if priorities_dict[current] < max(priorities):
            queue.append(current)
        else:
            prints.append(current)
            priorities.remove(priorities_dict[current])
    answer = prints.index(location) + 1

    return answer
