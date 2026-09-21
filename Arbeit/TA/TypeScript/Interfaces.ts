/**
 * Interface definieren das Aussehen eines Objektes, beinhaltet aber keine eigene Logik <=> Abstrahiert!
 * 
 * 1. Beinhaltet keinen Code
 * 2. Klassen können mehrere Interfaces implementieren
 * 3. Gelten für Typechecks
 * 
 * Fazit: Beschreibt fixe Vorraussetzungen für alle Klasse die das Interface implementieren
 */


interface Logger {
    log(message: string): void;
    readonly prefix: string;
}

class ConsoleLogger implements Logger{
    readonly prefix: string = "CLI-LOG";

    log(message: string): void {
        console.log('$(this.prefix)) $(message)')
    }
}

const log: ConsoleLogger = new ConsoleLogger();
log.log("SUCCESS BEI VSCODE")

const iLog: Logger = new ConsoleLogger();
iLog.log("NEXT SUCCESS")
