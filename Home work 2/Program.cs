using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання для вирiшення на тему ввiд вивiд");
            Console.WriteLine("Select");
            int n = 1;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            switch (n)
            {
                case 1:
                    IfElseSwich1.main();
                    break;
                case 2:
                    IfElseSwich2.main();
                    break;
                case 3:
                    IfElseSwich3.main();
                    break;
                case 4:
                    IfElseSwich4.main();
                    break;
                case 5:
                    IfElseSwich5.main();
                    break;
                case 6:
                    IfElseSwich6.main();
                    break;
                case 7:
                    IfElseSwich7.main();
                    break;
                case 8:
                    IfElseSwich8.main();
                    break;
                case 9:
                    IfElseSwich9.main();
                    break;
                case 10:
                    IfElseSwich10.main();
                    break;
                case 11:
                    IfElseSwich11.main();
                    break;
                case 12:
                    IfElseSwich12.main();
                    break;
                case 13:
                    IfElseSwich13.main();
                    break;
                case 14:
                    IfElseSwich14.main();
                    break;
                case 15:
                    IfElseSwich15.main();
                    break;
                case 16:
                    IfElseSwich16.main();
                    break;
                case 17:
                    IfElseSwich17.main();
                    break;
                case 18:
                    IfElseSwich18.main();
                    break;
                case 19:
                    IfElseSwich19.main();
                    break;
                case 20:
                    IfElseSwich20.main();
                    break;

                case 21:
                    While1.main();
                    break;
                case 22:
                    While2.main();
                    break;
                case 23:
                    While3.main();
                    break;
                case 24:
                    While4.main();
                    break;
                case 25:
                    While5.main();
                    break;
                case 26:
                    While6.main();
                    break;
                case 27:
                    While7.main();
                    break;
                case 28:
                    While8.main();
                    break;
                case 29:
                    While9.main();
                    break;
                case 30:
                    While10.main();
                    break;
                case 31:
                    While11.main();
                    break;
                case 32:
                    While12.main();
                    break;
                case 33:
                    While13.main();
                    break;
                case 34:
                    While14.main();
                    break;
                case 35:
                    While15.main();
                    break;
                case 36:
                    While16.main();
                    break;
                case 37:
                    While17.main();
                    break;
                case 38:
                    While18.main();
                    break;
                case 39:
                    While19.main();
                    break;
                case 40:
                    While20.main();
                    break;
                case 41:
                    While21.main();
                    break;
                case 42:
                    While22.main();
                    break;
                case 43:
                    While23.main();
                    break;
                case 44:
                    While24.main();
                    break;
                case 45:
                    While25.main();
                    break;
                case 46:
                    While26.main();
                    break;

                case 47:
                    For1.main();
                    break;
                case 48:
                    For2.main();
                    break;
                case 49:
                    For3.main();
                    break;
                case 50:
                    For4.main();
                    break;
                case 51:
                    For5.main();
                    break;
                case 52:
                    For6.main();
                    break;
                case 53:
                    For7.main();
                    break;
                case 54:
                    For8.main();
                    break;
                case 55:
                    For9.main();
                    break;
                case 56:
                    For10.main();
                    break;
                case 57:
                    For11.main();
                    break;
                case 58:
                    For12.main();
                    break;
                case 59:
                    For13.main();
                    break;
                case 60:
                    For14.main();
                    break;
                case 61:
                    For15.main();
                    break;
                case 62:
                    For16.main();
                    break;
                case 63:
                    For17.main();
                    break;
                case 64:
                    For18.main();
                    break;
                case 65:
                    For19.main();
                    break;
                case 66:
                    For20.main();
                    break;
                case 67:
                    For21.main();
                    break;
                case 68:
                    For22.main();
                    break;
                case 69:
                    For23.main();
                    break;
                case 70:
                    For24.main();
                    break;

                default:
                    Console.WriteLine("Out of Range");
                    break;
            }
        }
    }
}
