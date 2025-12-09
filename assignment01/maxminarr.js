function getMaxMin(arr) {
    if (arr.length === 0) return null;
    let max = arr[0];
    let min = arr[0];

    for (let i = 1; i < arr.length; i++) {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }

    return { max: max, min: min };
}
let numbers = [5, 8, 2, 10, 3];
let result = getMaxMin(numbers);
console.log("Max:", result.max); 
console.log("Min:", result.min); 
