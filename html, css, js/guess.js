const guessInput = document.getElementById('guess-input'); //user guess input
const guessBtn = document.getElementById('guess-btn'); //guess button
const result = document.getElementById('result');

const randomNumber = Math.floorloor(Math.random() * 100) + 1;