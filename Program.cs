/*Console.WriteLine("give me a number bettwen 1 and 100");
string input = Console.ReadLine();
for( int tal = int.Parse(input); tal<=101; tal++) {
    Console.Write(tal + "  ");
    if(tal >=101){
    Console.WriteLine(",");
    }

}*/
double small =0; 
double Big =0; 
double summa = 0 , input;
int antal= int.Parse(Console.ReadLine());
for(int i =0 ; i<5 ; i++){
    Console.WriteLine("skrive tal" + i + ":" );
    input = Convert.ToDouble(Console.ReadLine());
    summa = summa + input;
}
Console.WriteLine( "medelvärdet är" + (summa / antal) );

