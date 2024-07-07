/*   
 
    &&  == E          || == OU         ! == NÃO    
 
    precedencia = ! maior que && maior que ||        para quebrar a precedencia é necessaria a utilização de parentesis tbm 
 
 */


bool c1 = 4 != 5  && 2 > 3;
Console.WriteLine(c1);


bool c2 = 4 != 5 && 2 < 3;
Console.WriteLine(c2);



bool c3 = 4 != 5 || 2 > 3;
Console.WriteLine(c3);

bool c4 = 5 != 5 || 4 < 3;
Console.WriteLine(c4);


bool c5 = !(2 > 3) && 4 != 5;     //    Expressao  "  !  "   NÃO  nega o resutultado , oq é verdadeiro vira falso e vice versa
Console.WriteLine(c5);


bool c6 = !(4 > 3) && 4 != 5;     //    Expressao  "  !  "    NÃO  nega o resutultado , oq é verdadeiro vira falso e vice versa
Console.WriteLine(c6);




Console.WriteLine("----------------------------------------------------------------");


bool c7 = 10 < 5;

bool c8 = c5 || c6 && c7;     // Exemplo de precedencia com Operadores Logicos
Console.WriteLine(c8);