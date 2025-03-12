using System;
using jurnalModul4_103022300018;
    class Program
    {
        static void Main(string[] args)
        {
            // TEKNIK TABLE-DRIVEN
            kodeProduk kodeProduk = new kodeProduk();

            Console.WriteLine("Menampilkan Semua Daftar Elektronik:");
            string[] elektronikList = {"Laptop", "Smartphone", "Tablet", "Headset", "Keyboard", 
                "Mouse", "Printer", "Monitor", "Smartwacth", "Kamera"};
            foreach (string elektronik in elektronikList)
            {
            Console.WriteLine($"{elektronik}: {kodeProduk.GetKodeElektronik(elektronik)}");
            }


            FanLaptop fanLaptop = new FanLaptop();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine($"State saat ini : {fanLaptop.currentState}");
                Console.WriteLine("Masukan Trigger: mode_down, mode_up, turbo_shortcut");
                string inputFan = Console.ReadLine();

                switch (inputFan)
                {
                case "mode_down":
                    fanLaptop.changeState(FanLaptop.Trigger.mode_down);
                    break;
                case "mode_up":
                    fanLaptop.changeState(FanLaptop.Trigger.mode_up);
                    break;
                case "turbo_shortcut":
                    fanLaptop.changeState(FanLaptop.Trigger.turbo_shortcut);
                    break;
                case "exit":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Input tidak valid");
                    break;
                }
            }
        }
    }