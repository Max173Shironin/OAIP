print("Доступны 10 и 13 стр")
print("Введите страницу:")
page = int(input())
if page == 10:
    # с.10 № 18
    # N = 567
    N = int(input())
    c3 = N % 10
    c1 = N // 100
    c2 = N // 10 % 10  # N % 100 // 10
    print(f"{c1} \n {c2} \n {c3} \n {c3 - c2 == c2 - c1 and c2 - c1 != 0}")
elif page == 13:
    print("Доступны задания 1, 2, 3, 4:")
    print("Введите номер задания:")
    exec = int(input())
    if exec == 1:
        # c.13 №1
        # для каждой линии нужно определить уравнение
        # для закрашенной области определить систему неравенств
        x = float(input())
        y = float(input())
        # y >= 0
        # y <= x + 4
        # y <= -x + 4           1 < -1 + 4
        print(y >= 0 and y <= x + 4 and y <= -x + 4)
    elif exec == 2:
        x1 = float(input())
        y1 = float(input())
        print((x1 * x1) + (y1 * y1) >= 9 and (x1 * x1) + (y1 * y1) <= 25 and x1 >= 0)
    elif exec == 3:
        x2 = float(input())
        y2 = float(input())
        print((x2 >= -2) and (x2 <= 2) and (y2 <= 4) and (y2 >= -3) or (x2 >= -4) and (x2 <= 5) and (y2 <= 0) and (y2 >= -3))
    elif exec == 4:
        x3 = float(input())
        y3 = float(input())
        print((y3 >= 5 - x3) and (y3 <= 11 - x3) and (y3 <= x3 + 3) and (y3 >= x3 - 3))