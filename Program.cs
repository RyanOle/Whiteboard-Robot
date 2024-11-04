using System;

class TextPathing {
    private static double x = 500;
    private static double y = 500;
    private static double z = 495;
    private static double width = 30;
    private static double height = 50;
    private static double spacing = 5;
    private static double backUp = 5;

    
    static void Main(string[] args) {
        new TextPathing();
        text("z");
    }

    public static void text(string word) {        
        if (word == null) {
            Console.WriteLine("The word input was NULL!!!");
            return;
        } else {
            for(int i = 0; i < word.Length; i++) {
                Console.WriteLine(word[i] + "\n");
                pathing(word[i]);
            }
        }
    }

    public static void pathing(char letter) {
        //Every letter should start in an inital position of the top left
        //X, Y, Z assume for normal planes here 
        //x is left to right
        //y is up and down
        //z is forward and back
        switch (char.ToUpper(letter)) {
            case 'A':
                //Move to first contact point
                y -= height;
                printNumbers();
                //Marker touching
                z += backUp;
                printNumbers();

                //Draw
                x += width/2;
                y += height;
                printNumbers();
                x += width/2;
                y -= height;
                printNumbers();
                x -= width/4;
                y += height/2;
                printNumbers();
                x -= width/2;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                x += (width * (0.75)) + spacing;
                y += height/2;
                printNumbers();
                break;
            case 'B':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x += width * (0.75);
                printNumbers();
                x += width/4;
                y -= height/4;
                printNumbers();
                x -= width/4;
                y -= height/4;
                printNumbers();
                x -= width * (0.75);
                printNumbers();
                x += width * (0.75);
                printNumbers();
                x += width/4;
                y -= height/4;
                printNumbers();
                x -= width/4;
                y -= height/4;
                printNumbers();
                x -= width * (0.75);
                printNumbers();
                y += height;
                printNumbers();
                //Drawing Done
                
                //Move to next initial position
                z -= backUp;
                printNumbers();
                x += width + spacing;
                printNumbers();
                break;
            case 'C':
                Console.WriteLine("You entered C.");
                break;
            case 'D':
                Console.WriteLine("You entered D.");
                break;
            case 'E':
                Console.WriteLine("You entered E.");
                break;
            case 'F':
                Console.WriteLine("You entered F.");
                break;
            case 'G':
                Console.WriteLine("You entered G.");
                break;
            case 'H':
                Console.WriteLine("You entered H.");
                break;
            case 'I':
                Console.WriteLine("You entered I.");
                break;
            case 'J':
                Console.WriteLine("You entered J.");
                break;
            case 'K':
                Console.WriteLine("You entered K.");
                break;
            case 'L':
                Console.WriteLine("You entered L.");
                break;
            case 'M':
                Console.WriteLine("You entered M.");
                break;
            case 'N':
                Console.WriteLine("You entered N.");
                break;
            case 'O':
                Console.WriteLine("You entered O.");
                break;
            case 'P':
                Console.WriteLine("You entered P.");
                break;
            case 'Q':
                Console.WriteLine("You entered Q.");
                break;
            case 'R':
                Console.WriteLine("You entered R.");
                break;
            case 'S':
                Console.WriteLine("You entered S.");
                break;
            case 'T':
                x += width;
                printNumbers();
                x -= width/2;
                printNumbers();
                y -= height;
                printNumbers();
                break;
            case 'U':
                break;
            case 'V':
                Console.WriteLine("You entered V.");
                break;
            case 'W':
                Console.WriteLine("You entered W.");
                break;
            case 'X':
                Console.WriteLine("You entered X.");
                break;
            case 'Y':
                Console.WriteLine("You entered Y.");
                break;
            case 'Z':
                //At initial position
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x += width;
                printNumbers();
                x -= width;
                y -= height;
                printNumbers();
                x += width;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                x += spacing;
                y += height;
                printNumbers();
                break;
            default:
                Console.WriteLine("Unrecognized letter was entered!!!");
                break;
        }

        Console.WriteLine("");
    }

    public static void printNumbers() {
        //FIX ME, right now x, y, and z are on their assumed standard planes
        //If y is ends up being back and forward and z up and down simply switch z and y in the below format replacement
        Console.WriteLine(string.Format("G1 X={0} Y={1} Z={2} F3000", x, y, z));
    }
}
