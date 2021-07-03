def Sum(num1, num2):
    num3 = num1 + num2
    return num3


def Rest(num1, num2):
    num3 = num1 - num2
    return num3


def Divide(num1, num2):
    num3 = 0
    if num2 > 0:
        num3 = num1 / num2
    else:
        print("The divisor cant be 0")
    return num3


def Multiple(num1, num2):
    num3 = num1 * num2
    return num3


print("Select operation.")
print("1.Add")
print("2.Subtract")
print("3.Multiply")
print("4.Divide")

while True:
    choice = input("Enter choice(1/2/3/4): ")

    if choice in ('1', '2', '3', '4'):
        num1 = float(input("Enter first number: "))
        num2 = float(input("Enter second number: "))

        if choice == '1':
            print(num1, "+", num2, "=", Sum(num1, num2))

        elif choice == '2':
            print(num1, "-", num2, "=", Rest(num1, num2))

        elif choice == '3':
            print(num1, "*", num2, "=", Multiple(num1, num2))

        elif choice == '4':
            print(num1, "/", num2, "=", Divide(num1, num2))
        break
    else:
        print("Invalid Input")
