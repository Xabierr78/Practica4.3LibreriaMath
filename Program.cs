Console.WriteLine("Escribe un numero por favor:");

double a = double.Parse(Console.ReadLine());



double valorAbsoluto = Math.Abs(a);
double potencia = Math.Pow(valorAbsoluto,3); 
double raizCuadrada = Math.Sqrt(valorAbsoluto);


double seno = Math.Sin(Math.PI * valorAbsoluto /180);
double coseno=Math.Cos(Math.PI * valorAbsoluto/180);
double maximo=Math.Max(valorAbsoluto,50);
double minimo=Math.Min(valorAbsoluto,50);
double parteEntera= Math.Truncate(18.9323);
double redondeo =Math.Round(18.98);




Console.WriteLine("NUMERO: " + a + "\n" + "El valor absoluto es: " + valorAbsoluto + "\n" + "La potencia es " + potencia
    + "\n" + "La raiz cuadrada es: " + raizCuadrada + "\n" + "El seno es: " + seno + "\n" + 
    "El coseno es: " + coseno  + "\n" + "El maximo es: " + "\n" + "El minimo es: " + minimo 
    + "\n" + "La parte entera es: " + parteEntera  + "\n" + "El redondeo es: " + redondeo);

Console.WriteLine("\n" + "El ejemplo del ejercicio en el .PDF da como resultado un seno y coseno expresado en grados y el math.sin lo expresa en radianes , 2 horas mas tarde lo he conseguido convertir, vaya tela ");









