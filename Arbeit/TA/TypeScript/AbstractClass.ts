/**
 * Eine abstrakte Klasse ist ein Mittelding zwischen Klasse und Interface.
 * 
 * 1. Kann sowohl implementierte Methoden als auch abstrakte Methoden enthalten.
 * 2. Kann nicht direkt instanziiert werden.
 * 3. Muss von einer konkreten Klasse geerbt werden.
 * 
 * Fazit: Dient zur Generalisierung ähnlicher Klassen.
 */

abstract class PaymentProcessor {
    constructor(protected amount: number) {}

    displayAmount(): void {
        console.log(`Processing amount: ${this.amount}`)
    }

    abstract processPayment(): void
}

class StripePayment extends PaymentProcessor {
    processPayment(): void {
        console.log(`Charging ${this.amount} via Stripe API.`)
    }
}

class PayPalPayment extends PaymentProcessor {
    processPayment(): void {
        console.log(`Charging ${this.amount} via PayPal API.`)
    }
}

const stripePayment = new StripePayment(50)
stripePayment.displayAmount()
stripePayment.processPayment()

