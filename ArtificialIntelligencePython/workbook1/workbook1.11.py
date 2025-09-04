import matplotlib.pyplot as plt

months = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]

apple_prices = [129.41, 121.26, 122.15, 131.46, 124.61, 125.88, 145.88, 154.63, 141.50, 148.16, 165.29, 177.57]

microsoft_prices = [222.39, 231.38, 249.81, 255.51, 249.09, 270.27, 277.34, 300.06, 282.67, 332.48, 330.16, 335.02]

google_prices = [1756.01, 2036.39, 2061.54, 2262.71, 2282.97, 2521.60, 2707.40, 2781.95, 2598.70, 2847.20, 2855.51, 2895.85]

plt.plot(months, apple_prices, label="Apple")
plt.plot(months, microsoft_prices, label="Microsoft")
plt.plot(months, google_prices, label="Google")

plt.xlabel("Месяцы 2021")
plt.ylabel("Цена акции (USD)")
plt.title("Стоимость акций Apple, Microsoft и Google в 2021 году")
plt.legend()
plt.grid(True)  

plt.show()