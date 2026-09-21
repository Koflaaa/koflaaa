/**
 * Open/Closed Responsiblity beschreibt dsas Klassen offen für Erweiterungen (extends) sind, aber geschlossen für Modifikationen.
 */

class BadRectangle { constructor(public width: number, public height: number){} }
class BadCircle { constructor(public radius:number){} }

class BadAreaCalculator {
    public calculate(shape: any) {
        if(shape instanceof BadRectangle)
        {
            return shape.width * shape.height;
        } else if (shape instanceof BadCircle)
        {
            return Math.PI * shape.radius;
        }
    }
}

interface Shape {
    calculateArea(): number; 
}

class Rectangle implements Shape{
    
}