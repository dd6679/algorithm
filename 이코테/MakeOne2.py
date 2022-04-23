# 내 코드
# N, K을 공백을 기준으로 구분하여 입력 받기
n, k = map(int, input().split())

result = 0

while n != 1:
    if n % k == 0:
        n = n // k
        result += 1
    else:
        n = n - 1
        result += 1

print(result)
