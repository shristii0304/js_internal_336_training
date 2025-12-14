let user = {name: "Aman", age: 21, course: "JS"};
let jsonData = JSON.stringify(user);
let newUser = JSON.parse(jsonData);
console.log(jsonData);
console.log(newUser);