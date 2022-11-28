product, quantity = input().split(" ")
product, quantity = int(product), int(quantity)
price = [4, 4.5, 5, 2, 1.5]
print("Total: R$ {:.2f}".format(price[product-1]*quantity))
