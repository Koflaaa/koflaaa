// Reguläre Funktion
function greet(name){
    console.log("Hello ${name}")
}
greet("World")

// Funktion Expressions
const multiply = function(a,b){
    return a*b
};
console.log(typeof multiply, multiply(3,5))

// Arrow Function, auch Lambda-Funktion
const add = (a,b) => a+b;
console.log(typeof add, add(7,3))

