const prompt = require('prompt-sync')()

// 1
let songName = "I'm a barbie girl 👸"
console.log('1. Now playing: ' + songName)

// 2
let catMood = 'angry 😾'
console.log('2. Your cat is ' + catMood)

// 3
let isImpostor = true
console.log('3. Red impostor? ' + isImpostor)

// 4
let wow = 'wow',
	soJS = 'so JavaScript',
	muchCode = 'much code'
console.log('4. ' + wow + ' ' + soJS + ' ' + muchCode)

// 5
let likes = 77
let verified = false
console.log('5a. ' + typeof likes)
console.log('5b. ' + typeof verified)

// 6
let isOnion = true
console.log('6. ' + typeof isOnion)

// 7
let year = 2077
let hero = 'V'
let isReady = true
console.log('7a. ' + typeof year)
console.log('7b. ' + typeof hero)
console.log('7c. ' + typeof isReady)

// 8
let prize = 1000000
console.log('8. ' + typeof prize)

// 9
let situation = 'fire'
let reaction = 'this is fine'
console.log('9a. ' + typeof situation)
console.log('9b. ' + typeof reaction)

// 10
console.log('10. Диалоговое окно:')
let nickname = prompt("What's your Minecraft nickname?")
console.log('Привет ' + nickname + '!')

// 11
console.log('11. Диалоговое окно:')
let show = prompt("What's your favorite TV show?")
console.log('Tonight we binge: ' + show)

// 12 - Заменил confirm на prompt с проверкой ответа
console.log('12. Диалоговое окно:')
let wantLink = prompt('Do you want a link to cool JS docs? (yes/no) ')
if (wantLink.toLowerCase() === 'yes' || wantLink.toLowerCase() === 'y') {
	console.log("Here's the link!")
} else {
	console.log('Never gonna give you up')
}

// 13
console.log('13. Диалоговое окно:')
let hours = prompt('How many hours did you scroll today?')
console.log("Bruh, that's " + hours + ' hours... touch grass')

// 14
let userInput = prompt('Введи число биткоина:')
let bitcoinPrice = Number(userInput) + 1000
console.log('14. ' + bitcoinPrice)

// 15
let numberN = prompt('Введи число:')
let stringN = String(numberN)
console.log('15. ' + stringN)

// 16
let coffeeInput = prompt('How many coffees did you have today?')
let coffeeTotal = Number(coffeeInput) + 1
console.log('16. ' + coffeeTotal)

// 17
let karmaInput = prompt('Введи значение кармы:')
let karma = Number(karmaInput)
console.log('17. Total karma: ' + (karma + 10))

// 18
let likesInput = prompt('How many likes did your post get?')
let totalLikes = Number(likesInput) + 420
console.log('18. ' + totalLikes)

// 19
let money = 1000
money = money + 250
console.log('19. ' + money)

// 20
let coins = 350
let boosters = 5
let totalScore = coins + boosters * 100
console.log('20. Total score: ' + totalScore)

// 21
let pikachuHP = 100
let attack = 35
pikachuHP = pikachuHP - attack
console.log('21. ' + pikachuHP)

// 22
let players = 456
let eliminated = 100
let remaining = players - eliminated
console.log('22. ' + remaining)

// 23
let a = 10
let b = 3
console.log('23a. ' + a / b)
console.log('23b. ' + (a % b))
