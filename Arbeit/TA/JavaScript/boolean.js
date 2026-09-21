const vais = [
    3.14,
    "Hello World",
    true,
    false,
    undefined,
    Symbol('H1'),
]

const results = vais.flatMap(v =>
  vais.map(w => ({
    "Value A": String(v),
    "Value B": String(w),
    "Equals (==)": v == w,
    "Equals (===)": v === w,
  }))
);


//console.table(results)
