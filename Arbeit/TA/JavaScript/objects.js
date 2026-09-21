const car = {
    marke: "Toyota",
    model: "Tundra",
    year: 2022
}

// Als Funktion

function Car(marke, model, year){
    this.marke = marke
    this.model = model
    this.year = year
}

const myCar = new Car("Tsla", "Typ Y", "2025")


//Klasse

class KFZ{
    constructor(marke, model)
    {
        this.marke = marke
        this.model = model
    }
}

const myKFZ = new KFZ("VW", "Touran")