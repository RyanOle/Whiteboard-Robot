using System;

class TextPathing {
    private static double x = 0;
    private static double y = 550;
    private static double z = 300;
    private static double width = 20;
    private static double height = 50;
    private static double spacing = 5;
    private static double backUp = 5;

    
    static void Main(string[] args) {
        new TextPathing();
        text("q");
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
                x += width * (0.75);
                y += height/2;
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
                x += width;
                break;
            case 'C':
                //Move to first contact point
                x += width;
                y -= height/3;
                printNumbers();
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x -= width/3;
                y += height/3;
                printNumbers();
                x -= width/3;
                printNumbers();
                x -= width/3;
                y -= height/3;
                printNumbers();
                y -= height/3;
                printNumbers();
                x += width/3;
                y-= height/3;
                printNumbers();
                x += width/3;
                printNumbers();
                x += width/3;
                y += height/3;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                y += (height/3)*2;
                break;
            case 'D':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x += width * (0.75);
                printNumbers();
                x += width/4;
                y -= height/3;
                printNumbers();
                y -= height/3;
                printNumbers();
                x -= width/4;
                y -= height/3;
                printNumbers();
                x -= width * (0.75);
                printNumbers();
                y += height;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                x += width;
                break;
            case 'E':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x += width;
                printNumbers();
                x -= width;
                printNumbers();
                y -= height/2;
                printNumbers();
                x += width;
                printNumbers();
                x -= width;
                printNumbers();
                y -= height/2;
                printNumbers();
                x += width;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                y += height;
                break;
            case 'F':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x += width;
                printNumbers();
                x -= width;
                printNumbers();
                y -= height/2;
                printNumbers();
                x += width;
                printNumbers();
                x -= width;
                printNumbers();
                y -= height/2;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                x += width;
                y += height;
                break;
            case 'G':
                //Move to first contact point
                x += width;
                y -= height/3;
                printNumbers();
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x -= width/3;
                y += height/3;
                printNumbers();
                x -= width/3;
                printNumbers();
                x -= width/3;
                y -= height/3;
                printNumbers();
                y -= height/3;
                printNumbers();
                x += width/3;
                y-= height/3;
                printNumbers();
                x += width/3;
                printNumbers();
                x += width/3;
                y += height/3;
                printNumbers();
                x -= width/2;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                x += (width/2);
                y += (height/3) * 2;
                break;
            case 'H':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                y -= height;
                printNumbers();
                y += height/2;
                printNumbers();
                x += width;
                printNumbers();
                y -= height/2;
                printNumbers();
                y += height;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                break;
            case 'I':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x += width;
                printNumbers();
                x -= width/2;
                printNumbers();
                y -= height;
                printNumbers();
                x -= width/2;
                printNumbers();
                x += width;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                y += height;
                break;
            case 'J':
                //Move to first contact point
                y -= (height/3) * 2;
                printNumbers();
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x += width/3;
                y -= height/3;
                printNumbers();
                x += width/3;
                printNumbers();
                x += width/3;
                y += height/3;
                printNumbers();
                y += (height/3)*2;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                break;
            case 'K':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                y -= height;
                printNumbers();
                y += height/2;
                printNumbers();
                x += width;
                y -= height/2;
                printNumbers();
                x -= width;
                y += height/2;
                printNumbers();
                x += width;
                y += height/2;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                break;
            case 'L':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                y -= height;
                printNumbers();
                x += width;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                y += height;
                break;
            case 'M':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                y -= height;
                printNumbers();
                y += height;
                printNumbers();
                x += width/2;
                y -= height/2;
                printNumbers();
                x += width/2;
                y += height/2;
                printNumbers();
                y -= height;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                y += height;
                break;
            case 'N':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                y -= height;
                printNumbers();
                y += height;
                printNumbers();
                x += width;
                y -= height;
                printNumbers();
                y += height;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                break;
            case 'O':
                //Move to first contact point
                x += width;
                y -= height/3;
                printNumbers();
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x -= width/3;
                y += height/3;
                printNumbers();
                x -= width/3;
                printNumbers();
                x -= width/3;
                y -= height/3;
                printNumbers();
                y -= height/3;
                printNumbers();
                x += width/3;
                y-= height/3;
                printNumbers();
                x += width/3;
                printNumbers();
                x += width/3;
                y += height/3;
                printNumbers();
                y += height/3;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                y += height/3;
                break;
            case 'P':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                y -= height; 
                printNumbers();
                y += height;
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
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                x += width;
                y += height/2;
                break;
            case 'Q':
                //Move to first contact point
                x += width;
                y -= height/3;
                printNumbers();
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x -= width/3;
                y += height/3;
                printNumbers();
                x -= width/3;
                printNumbers();
                x -= width/3;
                y -= height/3;
                printNumbers();
                y -= height/3;
                printNumbers();
                x += width/3;
                y-= height/3;
                printNumbers();
                x += width/3;
                printNumbers();
                x += width/3;
                y += height/3;
                printNumbers();
                y += height/3;
                printNumbers();
                z -= backUp;
                printNumbers();
                x -= width/3;
                y -= height/3;
                printNumbers();
                z += backUp;
                printNumbers();
                x += width/3;
                y -= height/3;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                y += height;
                break;
            case 'R':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                y -= height; 
                printNumbers();
                y += height;
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
                x += width;
                y -= height/2;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                y += height;
                printNumbers();
                break;
            case 'S':
                //Move to first contact point
                y -= (height/6) * 5;
                printNumbers();
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                y -= height/6;
                x += width/3;
                printNumbers();
                x += width/3;
                printNumbers();
                x += width/3;
                y += height/6;
                printNumbers();
                y += height/6;
                printNumbers();
                x -= width/3;
                y += height/6;
                printNumbers();
                x -= width/3;
                printNumbers();
                x -= width/3;
                y += height/6;
                printNumbers();
                y += height/6;
                printNumbers();
                x += width/3;
                y += height/6;
                printNumbers();
                x += width/3;
                printNumbers();
                x += width/3;
                y -= height/6;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                y += height/6;
                break;
            case 'T':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x += width;
                printNumbers();
                x -= width/2;
                printNumbers();
                y -= height;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                x += width/2;
                y += height;
                break;
            case 'U':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                y -= (height/3)*2;
                printNumbers();
                x += width/3;
                y -= height/3;
                printNumbers();
                x += width/3;
                printNumbers();
                x += width/3;
                y += height/3;
                printNumbers();
                y += (height/3)*2;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                break;
            case 'V':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x += width/2;
                y -= height;
                printNumbers();
                x += width/2;
                y += height;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                break;
            case 'W':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                y -= height;
                printNumbers();
                x += width/2;
                y += height/2;
                printNumbers();
                x += width/2;
                y -= height/2;
                printNumbers();
                y += height;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                break;
            case 'X':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x += width;
                y -= height;
                printNumbers();
                z -= backUp;
                printNumbers();
                x -= width;
                printNumbers();
                z += backUp;
                printNumbers();
                x += width;
                y += height;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
                break;
            case 'Y':
                //At first point of contact
                //Marker touch
                z += backUp;
                printNumbers();

                //Draw
                x += width/2;
                y -= height/3;
                printNumbers();
                y -= (height/3) * 2;
                printNumbers();
                y += (height/3) * 2;
                printNumbers();
                x += width/2;
                y += height/3;
                printNumbers();
                //Drawing Done

                //Move to next initial position
                z -= backUp;
                printNumbers();
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
                y += height;
                break;
            default:
                Console.WriteLine("Unrecognized letter was entered!!!");
                break;
        }
        x += spacing;
        printNumbers();
        Console.WriteLine("");
    }

    public static void printNumbers() {
        Console.WriteLine(string.Format("G1 X{0} Y{1} Z{2} F3000", x, z, y));
    }
}
