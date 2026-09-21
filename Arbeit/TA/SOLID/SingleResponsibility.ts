/**
 * Das Single Responsibility Princip (SRP) beschreibt:
 *  Eine Klasse hat exakt einen Grund sich zu verändern
 *  Eine Klasse hat genau einen Grund zu existieren
 *  Eine Klasse hat genau einen Actor
 *  ...
 * 
 * Eine Klasse die zuviel implementiert beschreibt sich als fragile.
 * 
 */

class BadUser {
    constructor(public name:string, public email: string) {}
    
    
    rename(newName:string){
        this.name = newName;
    }

    validateEmail() {
        return this.email.includes('@');
    }

    saveToFile(){
        console.log(`Saving ${this} to file`)
    }
}

class User { // Record, Data Klass, Data Access Object (DAO)
    constructor(public name:string, public email: string) {}
    rename(name:string) {this.name = name}
}

class UserValidator{ // Globale Validator Klasse
    static(user: User){
        return user.email.includes("@")
    }
}

class UserRepository{
    save(user:User) {
        console.log(`DB:: Saving ${user} to storage.`)
    }
}



