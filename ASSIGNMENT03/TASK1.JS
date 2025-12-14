let marks = [80, 90, 70, 85, 95];

let average = marks.reduce((sum, mark) => sum + mark, 0) / marks.length;

console.log("Average Marks:", average);