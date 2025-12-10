function fun(n){
    return n*2;
}
let ch=74
console.log(fun(ch));

let arr=[1,2,3,4,5,"apple","banana" ,ch]
console.log(arr);



let fruit=["apple","banana","watermelom","litchi","grapes"]
for(let temp of fruit){
    console.log(temp);
}
console.log(fruit);
fruit.push("papaya");
fruit.pop();
fruit.unshift("kiwi");
fruit.shift();
fruit.indexOf("banana");
console.log(fruit);


let num=[2,4,,6,8];
let result=num.map(n=>n*2);
console.log(result);
 let number=[10,20,30,40,5,60];
let filter=number.filter(n=>n>20)
console.log(filter);
let sum=[1,2,3,4,5];
let total=sum.reduce((acc,val)=>acc+val,0);
console.log(total);
