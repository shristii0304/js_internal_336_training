let num1 = 10;
let num2 = 25;
let num3 = 15;
let max;
if (num1 >= num2 && num1 >= num3) {
    max = num1;
} else if (num2 >= num1 && num2 >= num3) {
    max = num2;
} else {
    max = num3;
}
console.log("The maximum number is: " + max);
