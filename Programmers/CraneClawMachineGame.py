def solution(board, moves):
    basket = []
    result = 0
    
    for i in moves:
        #크레인 작동위치 i-1
        i = i - 1
        for j in range(len(board)):
            if board[j][i] > 0:
                basket.append(board[j][i])
                board[j][i] = 0
                if len(basket) > 1:
                    if basket[-1] == basket[-2]:
                        result += 1
                        basket = basket[:-2]
                break
    return result*2
