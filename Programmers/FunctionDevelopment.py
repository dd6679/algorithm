def solution(progresses, speeds):
    answer = []
    queue = []
    
    for i in range(len(progresses)):
        count = 0
        progress = progresses[i]
        while progress < 100:
            progress += speeds[i]
            count+=1
        queue.append(count)
    
    num = queue.pop(0)
    function = 1
    
    while len(queue) > 0:
        if num >= queue[0]:
            queue.pop(0)
            function += 1
        else:
            num = queue.pop(0)
            answer.append(function)
            function = 1
    answer.append(function)
    
    return answer
