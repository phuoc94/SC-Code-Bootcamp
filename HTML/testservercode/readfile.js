const fs = require('fs')
const data = fs.readFileSync('./Numerot.txt', 'utf8')
const spittext = data.split("\n");
const convertoint = spittext.map(p => parseInt(p))
sum = convertoint.reduce((acc, curr) => acc + curr)
console.log(sum)
