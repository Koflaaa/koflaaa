let user = "Herbert";
let isAdmin = false;
let isOwner = false;
let isBanned = false;
//Boolean Algebra: && ||
if((isAdmin || isOwner) && !isBanned)
{
    console.log("Is allowed")
}


// Vergleichsoperatoren: < > >= <= === ==
// == -> Abstrakter Vergleich (nur Wert)
// === -> Strikter Vergleich (Wert und Typ)
let temp = 25;
let isSunny = true;

if(temp === 25 || (temp > 25 && isSunny))
{
    console.log("Fits.")
}

// Ternärer Operator

let age = 20;
let state = (age >= 20) ? "Adult" : "Child";
console.log(state);

// Short-Circuiting
// 
let un = "Anna";
let displayName = un && "Hello World"; // Anna && Gunther -> displayName = Gunther 
console.log(displayName);