using Oefening10;
using Oefening11;
using Oefening7;
using Oefening8;
using Oefening9;
using System;
using System.Collections.Generic;
using static Oefening8.Calendar;

namespace OefeningLes1SSE
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oefening7_Operators();
            // Oefening8_Calendar();
            // Oefening9_Tuples();
            // Oefening10_Waardenlijst();
            Oefening11_Extra();

        }

        private static void Oefening7_Operators()
        {
            Breuk breuk1 = new Breuk(5, 12);
            Breuk breuk2 = new Breuk(7, 18);
            Console.WriteLine($"{breuk1} + {breuk2} = {(breuk1 + breuk2)}");
            Console.WriteLine($"{breuk1} - {breuk2} = {(breuk1 - breuk2)}");
            Console.WriteLine($"{breuk1} * {breuk2} = {(breuk1 * breuk2)}");
            Console.WriteLine($"{breuk1} / {breuk2} = {(breuk1 / breuk2)}");
            Console.WriteLine($"{breuk1} > {breuk2} = {(breuk1 > breuk2)}");
            Console.WriteLine($"{breuk1} >= {breuk2} = {(breuk1 >= breuk2)}");
            Console.WriteLine($"{breuk1} != {breuk2} = {(breuk1 != breuk2)}");
            Console.WriteLine($"{breuk2} < {breuk1} = {(breuk2 < breuk1)}");
            Console.WriteLine($"{breuk2} <= {breuk1} = {(breuk2 <= breuk1)}");
            Breuk breuk1Clone = (Breuk)breuk1.Clone();
            Console.WriteLine($"{breuk1} == {breuk1Clone} = {(breuk1 == breuk1Clone)}");
        }

        private static void Oefening8_Calendar()
        {
            Calendar cal = new Calendar();
            
            cal.ShowDays(WeekPart.WorkDays, Show.Numbers);
            cal.ShowDays(WeekPart.Weekend, Show.Names);
            cal.ShowDays(WeekPart.Week);
            cal.AddEventDay("CleanUp", new List<WeekDay> { WeekDay.Monday, WeekDay.Friday, WeekDay.Sunday });
            cal.AddEventDay("Studying", new List<WeekDay> { WeekDay.Saturday });
            cal.ShowEvents();
        }

        private static void Oefening9_Tuples()
        {
            TupleCalendar cal = new TupleCalendar();
            
        }

        private static void Oefening10_Waardenlijst()
        {
            Waardenlijst<string, int> dic = new Waardenlijst<string,int> (10);
            Console.WriteLine($"Count: {dic.Count}");
            dic.Add("Zero", 0);
            dic.Add("One", 1);
            dic.Add("Two", 2);
            dic.Add("Three", 3);
            dic.Add("Four", 4);
            dic.Add("Five", 5);
            Console.WriteLine($"Count: {dic.Count}");
            Console.WriteLine($"Three: {dic["Three"]}");
            dic.Remove("Three");
            Console.WriteLine($"Two: {dic["Two"]}");
            Console.WriteLine($"Three: {dic["Three"]}");
            Console.WriteLine($"Four: {dic["Four"]}");
            dic.Clear();
            Console.WriteLine($"Count: {dic.Count}");
        }

        private static void Oefening11_Extra()
        {
            Personeelslid persoon = new Personeelslid { Personeelsnummer = 1, Voornaam = "Hayk", Familienaam = "Avetisyan" };
            Factuur factuur = new Factuur { Factuurnummer = 1456722456, Omschrijving = "Meubilair en uitrusting" };
            Betalingsmotor motor = new Betalingsmotor();
            motor.VoerBetalingUit(persoon);
            motor.VoerBetalingUit(factuur);
        }
    }
}
