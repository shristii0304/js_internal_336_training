function isArmstrong(num) {
    let sum = 0;
    let temp = num;
    let digits = 0;
    let t = temp;
    while (t > 0) {
        digits++;
        t = (t - (t % 10)) / 10; 
    }

    
    while (temp > 0) {
        let digit = temp % 10;
        let power = 1;

        
        for (let i = 0; i < digits; i++) {
            power *= digit;
        }

        sum += power;
        temp = (temp - digit) / 10;
    }

    return sum === num;
}
console.log(isArmstrong(153)); 
console.log(isArmstrong(9474)); 
console.log(isArmstrong(123)); 
