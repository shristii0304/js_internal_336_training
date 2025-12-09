let str = "Shristi Dubey";
let n = 0;
while (str[n] !== undefined) {
    n++;
}
let length = 0;
for (let i = n - 1; i >= 0; i--) {
    length++;
}

console.log("The length of the string is: " + length);
