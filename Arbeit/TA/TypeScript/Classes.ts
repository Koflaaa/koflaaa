/**
 * Eine Klasse ist ein Bauplan für ein Objekt
 */

class BankAccount{
    //Kapselung bzw. Encapsulation
    private balance: number;
    public readonly accountNumber: number;


    constructor(initDeposit: number, accountNumber: number) {
        this.balance = initDeposit;
        this.accountNumber = accountNumber;
    }

    public deposit(amount: number): void {
        if (amount <= 0)
        {
            throw new Error("Deposit must be at least 1.");
        }
        this.balance += amount;
    }

    get _balance(): number {
        return this.balance;
    }
}

const acc = new BankAccount(100, 123);
acc.deposit(500);

console.log(acc._balance);


class Dog{name: string = "Fido"};
class Human{name:string = "Hermann"}
const pet:Dog = new Human();