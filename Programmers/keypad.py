keypad = [[1,2,3],[4,5,6],[7,8,9],['*',0,'#']]

def distance(num, hand):
    for i in range(4):
        for j in range(3):
            if keypad[i][j] == num:
                h = (i,j)
            if keypad[i][j] == hand:
                n = (i,j)
    return abs(h[0]-n[0]) + abs(h[1]-n[1])
            
def solution(numbers, hand):
    answer = ''
    left = '*'
    right = '#'
    for n in numbers:
        if n in [1,4,7]:
            answer += 'L'
            left = n
        elif n in [3,6,9]:
            answer += 'R'
            right = n
        else:
            dis_left = distance(n,left)
            dis_right = distance(n,right)
            if dis_left == dis_right:
                if hand == 'left':
                    answer += 'L'
                    left = n
                else:
                    answer += 'R'
                    right = n
            elif dis_right > dis_left:
                answer += 'L'
                left = n
            else:
                answer += 'R'
                right = n                   
    return answer
