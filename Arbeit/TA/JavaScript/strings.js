let single = "Hello";
let double = "World";
let backtick = `${single} great ${double}`;

//console.log(single, double, backtick);


let stringOperators = {
    setString: String(3.14),
    setStringObj: new String(3.14),
    getIndex: backtick[4],
    addNumber: single + 2024,
    addString: single + double,
    compareString: single > double,

}

//console.log(stringOperators)


let StringMethods = {
    upper: single.toUpperCase(),
    lower: single.toLowerCase(),
    charAt: backtick.charAt(4),
    slice: backtick.slice(3,10),
    includes: double.includes("or"),
    replace: backtick.replace("World", "Leute"),
}

console.log(StringMethods);