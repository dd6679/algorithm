def solution(brown, yellow):
    answer = []
    count = brown + yellow
    # 카펫의 가로 길이는 세로 길이와 같거나 세로 길이보다 김
    length = (brown - 4) // 2
    
    for i in range(1, length):
        if (i+2) * (length - i + 2) == count:
            answer.append(i+2)
            answer.append(length - i + 2)
            break
    
    answer.sort(reverse = True)
    
    return answer
