namespace PZ_18_1_
{

        internal class Program
        {
            enum Marks
            {
                ohenploxo = 1,
                ploxo = 2,
                ydovletvoritelno = 3,
                horowo = 4,
                otlichno = 5,

            }
            static void Kol(Marks ozenka)
            {
                switch (ozenka)
                {
                    case Marks.ohenploxo:
                        Console.WriteLine("очень плохо");
                        break;

                    case Marks.ploxo:
                        Console.WriteLine("неудовлетворительно");
                        break;

                    case Marks.ydovletvoritelno:
                        Console.WriteLine("удовлетворительно");
                        break;

                    case Marks.horowo:
                        Console.WriteLine("хорошо");
                        break;

                    case Marks.otlichno:
                        Console.WriteLine("отлично");
                        break;

                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine(">> введите отметку \n ");
                Console.Write("<< "); int ozenka = Convert.ToInt32(Console.ReadLine());

                if (ozenka == 1)
                {
                    Console.Write("\n>> характестика отметки 1: "); Kol(Marks.ohenploxo);
                }
                if (ozenka == 2)
                {
                    Console.Write("\n>> характестика отметки 2: "); Kol(Marks.ploxo);
                }
                if (ozenka == 3)
                {
                    Console.Write("\n>> характестика отметки 3: "); Kol(Marks.ydovletvoritelno);
                }
                if (ozenka == 4)
                {
                    Console.Write("\n>> характестика отметки 4: "); Kol(Marks.horowo);
                }
                if (ozenka == 5)
                {
                    Console.Write("\n>> характестика отметки 5: "); Kol(Marks.otlichno);
                }
                Console.WriteLine();
            }
        }

}