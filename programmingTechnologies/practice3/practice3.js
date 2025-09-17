const prompt = require('prompt-sync')()

// Задача 1
let a = 2 * (3 - 1)
let b = 6 - 2
console.log('Задача 1: a =', a)
console.log('Задача 1: b =', b)
console.log('Задача 1: a == b:', a == b)

// Задача 2
let number = prompt('Задача 2 — Введите число: ')
number = Number(number)
if (number > 0) {
	console.log('Задача 2: 1')
} else if (number < 0) {
	console.log('Задача 2: -1')
} else {
	console.log('Задача 2: 0')
}

// Задача 3
let word = prompt('Задача 3 — Введите слово (3–50 символов): ')
if (word.length % 2 === 1) {
	let middleIndex = Math.floor(word.length / 2)
	console.log('Задача 3: Средний символ:', word[middleIndex])
} else {
	let middle1 = word.length / 2 - 1
	let middle2 = word.length / 2
	console.log('Задача 3: Два средних символа:', word[middle1] + word[middle2])
}

// Задача 4
let a4 = Number(prompt('Задача 4 — Введите число a: '))
let b4 = Number(prompt('Задача 4 — Введите число b: '))
let result = a4 + b4 < 4 ? 'Мало' : 'Много'
console.log('Задача 4:', result)

// Задача 5
let login = prompt('Задача 5 — Кто там? ')
let message =
	login === 'Сотрудник'
		? 'Привет'
		: login === 'Директор'
		? 'Здравствуйте'
		: login === ''
		? 'Нет логина'
		: ''
console.log('Задача 5:', message)

// Задача 6
let userLogin = prompt('Задача 6 — Кто там? ')
if (userLogin === 'Админ') {
	let password = prompt('Задача 6 — Пароль? ')
	if (password === 'Я главный') {
		console.log('Задача 6: Здравствуйте!')
	} else if (password === null || password === '') {
		console.log('Задача 6: Отменено')
	} else {
		console.log('Задача 6: Неверный пароль')
	}
} else if (userLogin === null || userLogin === '') {
	console.log('Задача 6: Отменено')
} else {
	console.log('Задача 6: Я вас не знаю')
}

// Задача 7
let num = Number(prompt('Задача 7 — Введите число: '))
let isEvenTwoDigit = num >= 10 && num <= 99 && num % 2 === 0
let isOddThreeDigit = num >= 100 && num <= 999 && num % 2 === 1
if (isEvenTwoDigit || isOddThreeDigit) {
	console.log('Задача 7: YES')
} else {
	console.log('Задача 7: NO')
}

// Задача 8
let year = Number(prompt('Задача 8 — Введите год: '))
if ((year % 4 === 0 && year % 100 !== 0) || year % 400 === 0) {
	console.log('Задача 8: YES')
} else {
	console.log('Задача 8: NO')
}

// Задача 9
console.log('Задача 9: Числа от 100 до 1:')
for (let i = 100; i >= 1; i--) {
	console.log(i)
}

// Задача 10
console.log('Задача 10: Числа, кратные 3, от 1 до 100:')
for (let i = 1; i <= 100; i++) {
	if (i % 3 === 0) {
		console.log(i)
	}
}

// Задача 11
let sum = 0
for (let i = 1; i <= 100; i++) {
	if (i % 2 === 0) {
		sum += i
	}
}
console.log('Задача 11: Сумма чётных чисел от 1 до 100:', sum)

// Задача 12
let str = prompt('Задача 12 — Введите строку: ')
let reversed = ''
for (let i = str.length - 1; i >= 0; i--) {
	reversed += str[i]
}
console.log('Задача 12: Перевернутая строка:', reversed)

// Задача 13
let inputStr = 'SWAT'
let result13 = ''
for (let i = 0; i < inputStr.length; i++) {
	result13 += inputStr[i]
	if (i < inputStr.length - 1) {
		result13 += ' '
	}
}
console.log('Задача 13:', result13)

// Задача 14
let phrase = prompt(
	'Задача 14 — Введите фразу для проверки на панграмму: '
).toLowerCase()
let alphabet = 'abcdefghijklmnopqrstuvwxyz'
let isPangram = true
for (let i = 0; i < alphabet.length; i++) {
	if (!phrase.includes(alphabet[i])) {
		isPangram = false
		break
	}
}
if (isPangram) {
	console.log('Задача 14: yes')
} else {
	console.log('Задача 14: no')
}
