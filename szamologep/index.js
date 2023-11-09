let resultElement = document.getElementById('result');
let currentResult = '0';

function clearResult() {
        currentResult = '0';
        updateResult();
}

function appendToResult(value) {
    if (currentResult === '0' && value !== '.') {
        currentResult = value;
    } else {
        currentResult += value;
    }
    updateResult();
}

function calculateResult() {
    try {
        currentResult = eval(currentResult);
        updateResult();
    } catch (error) {
        currentResult = 'Error';
        updateResult();
    }
}

function updateResult() {
    resultElement.innerText = currentResult;
}