// 
DisplayMenu();
RouteMenuChoice(); 
// end main 

static void DisplayMenu(){
    System.Console.WriteLine("Press any key to continue.");
    Console.ReadKey();
    Console.Clear();
    System.Console.WriteLine("1. Print a full triangle.");
    System.Console.WriteLine("2. Print a partial triangle");
    System.Console.WriteLine("3. Exit");
}

static void RouteMenuChoice(){
    DisplayMenu();
    string userInput= Console.ReadLine();
    if(userInput!= "3" ) {
        switch(userInput){
           case "1": 
                GetFull();
                break;
            case "2":
                GetPartial();
                break;
            default:
                System.Console.WriteLine("Try again.");
                RouteMenuChoice();
                break;
        }
    }
    else{
        System.Console.WriteLine("Bye!");
    }  
}
    
static void GetFull(){
   Random rnd= new Random();
    int number= rnd.Next(3, 10);

    for (int i = 0; i < number; i++){
        for(int j= 0; j<=i; j++ ){
         System.Console.Write("0");
     }
        System.Console.WriteLine("");
    }
}

static void GetPartial(){
    Random rnd = new Random();
    int number = rnd.Next(3, 10);

    for(int i=0; i<number; i++){
        for(int j=0; j<=i; j++){
            Random dnr= new Random();
            int newNumber = dnr.Next(2);
            if (newNumber==0){
                System.Console.Write(" ");
            }
            else if (newNumber == 1) {
                System.Console.Write("0");
            }
        }
    System.Console.WriteLine("");
    }
}