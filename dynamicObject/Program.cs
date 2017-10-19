using System;


class Program
{
    static void Main()
    {
        dynamic age = new System.Dynamic.ExpandoObject();
        age.Toshko = 29; //"age" e от тип "integer"
        age.Poli = 27; //"age" e от тип "integer"
        age.Krasi = 53; //"age" e от тип "integer"
        age.Tolyo = ", Apostol Chupov is 54 years old"; //тука "age" e от тип "string"

        //Сега в Console.Writeline() мога да поставя и разпечатам, която и да е от вариантите на "age".
        Console.WriteLine(age.Poli);
        Console.WriteLine(age.Toshko + age.Poli); //тука се сумитрат променливите от тип "integer"
        Console.WriteLine(age.Krasi + age.Tolyo);
    }
}
