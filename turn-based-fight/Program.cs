namespace turn_based_fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // {ATK,DEF,HP} Max ATK is 100, Max DEF is 50 and Max HP is 400
            // DEF means that if you get hit damage will be absorbed as your DEF point.

            int[] Tank = { 60, 50, 350 };
            int[] ADC = { 100, 30, 300 };
            int[] Support = { 60, 40, 400 };
            int[] APC = { 100, 35, 325 };

            int[] oyuncu;
            int oyuncuATK = 0;
            int oyuncuDEF = 0;
            int oyuncuHP = 0;
            string oyuncuKarakter = "";

            Random rnd = new Random();
            int npcSecim = rnd.Next(1, 5);
            int[] npc;
            int npcATK = 0;
            int npcDEF = 0;
            int npcHP = 0;
            string npcKarakter = "";

            // For turn-based games, we need a turn counter. Max turn number must up to be 10-100. If you can't calculate the turn number, give 100.

            int turn = 20;

            Console.WriteLine("----Character Selection----\n\n1. Braum (Tank)\nStats:\nHP: 350 \nATK: 60\nDEF: 50\n\n2. Vayne (ADC)\nStats:\nHP: 300 \nATK: 100\nDEF: 30\n\n3. Bard (Support)\nStats:\nHP: 400 \nATK: 60\nDEF: 40\n\n4. Amumu (APC)\nStats:\nHP: 325 \nATK: 100\nDEF: 35\n\n");
            Console.WriteLine("Select your champion!");

            int karakterSecim = int.Parse(Console.ReadLine());

            Random random = new Random();
            int baslangic = random.Next(1, 3);
            Console.WriteLine("Who's gonna first? Pick 1 or 2. This choice will be your fate!");
            int baslangicSecim = int.Parse(Console.ReadLine());

            while (karakterSecim == npcSecim)
            {
                npcSecim = rnd.Next(1, 5);
            }

            if (karakterSecim == 1)
            {
                oyuncuKarakter = "Braum";
                oyuncu = Tank;
                oyuncuATK = oyuncu[0];
                oyuncuDEF = oyuncu[1];
                oyuncuHP = oyuncu[2];
                Console.WriteLine($"You're starting the game with {oyuncuKarakter}\t");
                //Console.WriteLine($"Stats\n HP: {oyuncuHP} ATK: {oyuncuATK} DEF: {oyuncuDEF}");
            }
            else if (karakterSecim == 2)
            {
                oyuncuKarakter = "Vayne";
                oyuncu = ADC;
                oyuncuATK = oyuncu[0];
                oyuncuDEF = oyuncu[1];
                oyuncuHP = oyuncu[2];
                Console.WriteLine($"You're starting the game with {oyuncuKarakter}");
                //Console.WriteLine($"Canınız: {oyuncuHP} Atak Puanınız: {oyuncuATK} Defans Puanınız: {oyuncuDEF}");
            }
            else if (karakterSecim == 3)
            {

                oyuncuKarakter = "Bard";
                oyuncu = Support;
                oyuncuATK = oyuncu[0];
                oyuncuDEF = oyuncu[1];
                oyuncuHP = oyuncu[2];
                Console.WriteLine($"You're starting the game with {oyuncuKarakter}");
                //Console.WriteLine($"Canınız: {oyuncuHP} Atak Puanınız: {oyuncuATK} Defans Puanınız: {oyuncuDEF}");
            }
            else if (karakterSecim == 4)
            {
                oyuncuKarakter = "Amumu";
                oyuncu = APC;
                oyuncuATK = oyuncu[0];
                oyuncuDEF = oyuncu[1];
                oyuncuHP = oyuncu[2];
                Console.WriteLine($"You're starting the game with {oyuncuKarakter}");
                //Console.WriteLine($"Canınız: {oyuncuHP} Atak Puanınız: {oyuncuATK} Defans Puanınız: {oyuncuDEF}");
            }

            if (npcSecim == 1)
            {
                npc = Tank;
                npcKarakter = "Braum";
                npcATK = npc[0];
                npcDEF = npc[1];
                npcHP = npc[2];
                Console.WriteLine($"NPC started the game with {npcKarakter}");
            }
            else if (npcSecim == 2)
            {
                npc = ADC;
                npcKarakter = "Vayne";
                npcATK = npc[0];
                npcDEF = npc[1];
                npcHP = npc[2];
                Console.WriteLine($"NPC started the game with {npcKarakter}");
            }
            else if (npcSecim == 3)
            {
                npc = Support;
                npcKarakter = "Bard";
                npcATK = npc[0];
                npcDEF = npc[1];
                npcHP = npc[2];
                Console.WriteLine($"NPC started the game with {npcKarakter}");
            }
            else if (npcSecim == 4)
            {
                npc = APC;
                npcKarakter = "Amumu";
                npcATK = npc[0];
                npcDEF = npc[1];
                npcHP = npc[2];
                Console.WriteLine($"NPC started the game with {npcKarakter}");
            }

            if (baslangic == baslangicSecim)
            {
                while (oyuncuHP > 0 && npcHP > 0)
                {

                    for (int tur = 1; tur <= turn; tur++)
                    {

                        if (oyuncuHP > 0 && npcHP > 0)
                        {
                            npcHP = npcHP + npcDEF - oyuncuATK;

                            if (npcHP <= 0)
                            {
                                Console.WriteLine("\n----Game Over----");
                                Console.WriteLine($"You hit {oyuncuATK}! {npcKarakter}'s health is 0");
                                Console.WriteLine("You win!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"\n------Round {tur}------");
                                Console.WriteLine($"You hit {oyuncuATK}! {npcKarakter}'s health is {npcHP}. Hit harder!");
                            }

                        }
                        if (npcHP > 0 && oyuncuHP > 0)
                        {
                            oyuncuHP = oyuncuHP + oyuncuDEF - npcATK;

                            if (oyuncuHP <= 0)
                            {
                                Console.WriteLine("\n----Game Over----");
                                Console.WriteLine($"Aww! {npcKarakter} hit {npcATK}! Your health is 0");
                                Console.WriteLine("You died!");
                                break;
                            }
                            else
                            {

                                Console.WriteLine($"Aww! {npcKarakter} hit {npcATK}! Your health is {oyuncuHP}. Take a breath!");
                            }
                        }

                    }
                }
            }
            else
            {
                while (oyuncuHP > 0 && npcHP > 0)
                {

                    for (int tur = 1; tur <= turn; tur++)
                    {

                        if (npcHP > 0 && oyuncuHP > 0)
                        {
                            oyuncuHP = oyuncuHP + oyuncuDEF - npcATK;

                            if (oyuncuHP <= 0)
                            {
                                Console.WriteLine("\n----Game Over----");
                                Console.WriteLine($"Aww! {npcKarakter} hit {npcATK}! Your health is 0");
                                Console.WriteLine("You died!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"\n------Round {tur}------");
                                Console.WriteLine($"Aww! {npcKarakter} hit {npcATK}! Your health is {oyuncuHP}. Take a breath!");
                            }
                        }

                        if (oyuncuHP > 0 && npcHP > 0)
                        {
                            npcHP = npcHP + npcDEF - oyuncuATK;

                            if (npcHP <= 0)
                            {
                                Console.WriteLine("\n----Game Over----");
                                Console.WriteLine($"You hit {oyuncuATK}! {npcKarakter}'s health is 0");
                                Console.WriteLine("You win!");
                                break;
                            }
                            else
                            {

                                Console.WriteLine($"You hit {oyuncuATK}! {npcKarakter}'s health is {npcHP}");
                            }

                        }

                    }
                }
            }





        }
    }
}
