const fruits = ['apple', 'banana']
const vegetables = {potatoe: 2, tomatoe: 5}

// For Loop

for(let i = 0; i < fruits.length; i++)
{
    //console.log(fruits)
}

// For-Each: Optimal für arrays, nicht für objekte

fruits.forEach((fruit, index) => {
    //console.log(index, fruit)
})

// For-Of: Iterables (interfaces), Arrays

for(let fruit of fruits)
{
    //console.log(fruit)
}

// For-In: Opimal für Key-Value Objekte

for(let key in vegetables){
    //console.log(key, vegetables[key])
}

