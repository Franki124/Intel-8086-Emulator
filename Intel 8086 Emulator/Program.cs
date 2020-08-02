using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intel_8086_Emulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program uruchamiany jest w jednej pętli sprawdzającej komendy wpisane przez użytkownika, wszystkie dostępne instrukcje znajdują się w komendzie help (wielkość liter oraz whitespace'y są bez znaczenia).

            //Definicja zmiennych rejestrów przechowujących aktualny stan ich wartości.

            int AX;
            int BX;
            int CX;
            int DX;
            int val;

            AX = 0;
            BX = 0;
            CX = 0;
            DX = 0;

            //Definicja string'ów wykorzystywanych przy operacjach 


            //Zmienna reg odpowiedzialna jest za zapisanie informacji o wybranym przez użytkownika rejestrze.
            string reg;
            //Zmienna ins odpowiedzialna za zapisanie informacji tekstowej odnośnie wybranej przez użytkownika instrukcji.
            string ins;
            //Zmienna input odpowiedzialna za zapis informacji odnośnie wartości która zostanie przydzielona odpowiednim rejestrom w wykonywanych instrukcjach.
            string input;

            //Główna pętla while będąca kręgosłupem programu.
            while (true)
            {
                Console.Write("Wpisz instrukcję:");
                ins = Console.ReadLine().ToUpper().Trim();

                if (ins.Contains("REG"))
                {
                    Console.WriteLine("AX = " + AX + " " + "BX = " + BX + " " + "CX = " + CX + " " + "DX = " + DX + " ");
                    continue;
                }
                if (ins.Contains("ADD")) 
                {
                    Console.WriteLine("Wybierz rejestr: ");
                    reg = Console.ReadLine().ToUpper();
                    if (reg.Contains("AX"))
                    {
                        Console.WriteLine("Podaj wartość: ");
                        input = Console.ReadLine().ToUpper();
                        Int32.TryParse(input, out val);
                        AX = AX + val;
                        continue;
                    }
                    if (reg.Contains("BX"))
                    {
                        Console.WriteLine("Podaj wartość: ");
                        input = Console.ReadLine().ToUpper();
                        Int32.TryParse(input, out val);
                        BX = BX + val;
                        continue;
                    }
                    if (reg.Contains("CX"))
                    {
                        Console.WriteLine("Podaj wartość: ");
                        input = Console.ReadLine().ToUpper();
                        Int32.TryParse(input, out val);
                        CX = CX + val;
                        continue;
                    }
                    if (reg.Contains("DX"))
                    {
                        Console.WriteLine("Podaj wartość: ");
                        input = Console.ReadLine().ToUpper();
                        Int32.TryParse(input, out val);
                        CX = DX + val;
                        continue;
                    }
                    ;
                }
                if (ins.Contains("SUB")) 
                {
                    Console.WriteLine("Wybierz rejestr: ");
                    reg = Console.ReadLine().ToUpper();
                    if (reg.Contains("AX"))
                    {
                        Console.WriteLine("Podaj wartość: ");
                        input = Console.ReadLine().ToUpper();
                        Int32.TryParse(input, out val);
                        AX = AX - val;
                        if (AX < 0) AX = 0;
                        continue;
                    }
                    if (reg.Contains("BX"))
                    {
                        Console.WriteLine("Podaj wartość: ");
                        input = Console.ReadLine().ToUpper();
                        Int32.TryParse(input, out val);
                        BX = BX - val;
                        if (BX < 0) BX = 0;
                        continue;
                    }
                    if (reg.Contains("CX"))
                    {
                        Console.WriteLine("Podaj wartość: ");
                        input = Console.ReadLine().ToUpper();
                        Int32.TryParse(input, out val);
                        CX = CX - val;
                        if (CX < 0) CX = 0;
                        continue;
                    }
                    if (reg.Contains("DX"))
                    {
                        Console.WriteLine("Podaj wartość: ");
                        input = Console.ReadLine().ToUpper();
                        Int32.TryParse(input, out val);
                        DX = DX - val;
                        if (DX < 0) DX = 0;
                        continue;
                    }
                    ;
                }
                if (ins.Contains("MOV")) 
                {
                    int regvalue;
                    Console.Write("Podaj pierwszy rejestr: ");
                    reg = Console.ReadLine().ToUpper();
                    if (reg.Contains("AX"))
                    {
                        regvalue = AX;
                        MOV2(ref AX, ref BX, ref CX, ref DX, regvalue);
                        continue;
                    }
                    if (reg.Contains("BX"))
                    {
                        regvalue = BX;
                        MOV2(ref AX, ref BX, ref CX, ref DX, regvalue);
                        continue;
                    }
                    if (reg.Contains("CX"))
                    {
                        regvalue = CX;
                        MOV2(ref AX, ref BX, ref CX, ref DX, regvalue);
                        continue;
                    }
                    if (reg.Contains("DX"))
                    {
                        regvalue = DX;
                        MOV2( ref AX, ref BX, ref CX, ref DX, regvalue);
                        continue;
                    }
                }
                if (ins.Contains("EXIT"))
                {
                    break;
                }
                if (ins.Contains("HELP"))
                {
                    Console.WriteLine("Dostępne instrukcje: ");
                    Console.WriteLine("HELP - wyświetla listę dostępnych instrukcji");
                    Console.WriteLine("REG - wyświetla aktualny status dostępnych rejestrów");
                    Console.WriteLine("ADD - pozwala na dodanie wartości do rejestru");
                    Console.WriteLine("SUB - pozwala na odjęcie wartości od rejestru");
                    Console.WriteLine("MOV - pozwala na przeniesienie wartości jednego rejestru na drugi");
                    Console.WriteLine("EXIT - pozwala na wyjście z programu");
                }
            }
        }
        private static void MOV2(ref int AX, ref int BX, ref int CX, ref int DX, int regvalue)
        {
            Console.Write("Podaj drugi rejestr: ");
            string reg = Console.ReadLine().ToUpper();
            if (reg.Contains("AX"))
            {
                AX = regvalue;
            }
            if (reg.Contains("BX"))
            {
                BX = regvalue;
            }
            if (reg.Contains("CX"))
            {
                CX = regvalue;
            }
            if (reg.Contains("DX"))
            {
                DX = regvalue;
            }
        }
    }
}
