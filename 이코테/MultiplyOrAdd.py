s = input()

num = int(s[0])

for i in range(1, len(s)):
    data = int(s[i])
    if num + data > num * data:
        num = num + data
    else:
        num = num * data

print(num)
