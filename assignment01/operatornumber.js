

function calculate(num1, num2, operator) {
    let result;

    switch(operator) {
        case "plus":
        case "+":
            result = num1 + num2;
            break;
        case "minus":
        case "-":
            result = num1 - num2;
            break;
        case "multiply":
        case "*":
            result = num1 * num2;
            break;
        case "divide":
        case "/":
            if (num2 !== 0) {
                result = num1 / num2;
            } else {
                return "Error: Division by zero!";
            }
            break;
        default:
            return "Invalid operator!";
    }

    return result;
}

// Test
console.log(calculate(10, 5, "plus"));   
console.log(calculate(10, 5, "minus"));   
console.log(calculate(10, 5, "multiply"));
console.log(calculate(10, 5, "divide"));   
console.log(calculate(10, 0, "divide"));   