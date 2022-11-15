
int server = Random.Shared.Next(1, 3);
int Checker = 0;
Console.WriteLine("Game mode ?");
string gameMode = Console.ReadLine()!;
int gamelength = 0;
int game1 = 0; int game2 = 0; int point1 = 0; int point2 = 0;
switch (gameMode){
    case "Short": gamelength = 1; break;
    case "regular": gamelength = 4; break;
    case "double": gamelength = 3; break;
   case "coustum": do{
        Console.Write("How man games to you want to play(the amout of the game´s must be ood");
        int coustum = int.Parse(Console.ReadLine()!);
         Checker = coustum % 2;

    }while(Checker  == 0); break;
    
}
do{
     point1 = 0;  point2 = 0;
        do{ 
            Console.WriteLine("Who won ? ");
            string winner = (Console.ReadLine()!);
            if(server == 1){
                System.Console.WriteLine("Player 1 is servering");
            }
            else if(server == 2){   
                Console.WriteLine("Player 2 is severing");
            }          
            switch (winner){
                case "1": point1++; break;
                case "2": point2++; break;
                case "q": return; 

            
            }
        Console.WriteLine( $"The current socre is {point1} : {point2} ");   
        
        }while(point1 != 11 && point2 != 11);
        if (point1 == 11)
        {game1++;
            System.Console.WriteLine("Player 1 won the game");}
        else if(point2 == 11  ){
            game2++;
            System.Console.WriteLine("Player 2 won the game");}
        System.Console.WriteLine($"On games it is {game1} : {game2} ");



}while(game1 != gamelength && game2 != gamelength);