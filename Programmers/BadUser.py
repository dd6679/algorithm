import random

def solution(user_id, banned_id):
    answer = set()
    data = {}
    check = {}
    def checking(depth, banned_num):
        if depth == banned_num:
            temp = ''
            for k, v in check.items():
                if v == 1:
                    temp += k
            answer.add(temp)
            return

        each_banned = banned_id[depth]
        for each_candi in data[each_banned]:
            if check[each_candi] == 0:
                check[each_candi] = 1
                checking(depth+1, banned_num)
                check[each_candi] = 0
                
    #banned_id의 문자열 길이를 비교하고
    #별표 뺀 위치에 있는 문자끼리만 비교
        
    for i in range(len(banned_id)):
        l = []
        for j in user_id:
            if len(j) == len(banned_id[i]):
                for n in range(len(banned_id[i])):
                    ban = banned_id[i]
                    if ban[n] != '*':
                        if j[n] != ban[n]:
                            break
                    if n == (len(ban)-1):
                        l.append(j)
                        data[ban] = l
                        check[j] = 0
    
    print(check)
    checking(0, len(banned_id))
    print(answer)
    print(data)
    return len(list(answer))
