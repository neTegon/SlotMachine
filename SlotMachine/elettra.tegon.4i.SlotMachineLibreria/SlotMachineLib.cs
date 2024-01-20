namespace elettra.tegon._4i.SlotMachineLibreria
{
    public class SlotMachineLib
    {
        
        private const int jackpot = 100;
        private const int consecutive = 50;
        private char val1;
        private char val2;
        private char val3;
        private int _monete;

        public int Monete { get => _monete; set => _monete = value; }
        public char Val1 { get => val1; set => val1 = value; }
        public char Val2 { get => val2; set => val2 = value; }
        public char Val3 { get => val3; set => val3 = value; }

        public SlotMachineLib(int monete)
        {
            this.Monete = monete;
        }

        public void carte()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 27);
            int num2 = rnd.Next(1, 27);
            int num3 = rnd.Next(1, 27);
            string s;
            char[] ascii = new char[26];
            ascii[0] = 'a';
            for (int i = 1; i < ascii.Length; i++)
            {
                ascii[i] = Convert.ToChar(ascii[i - 1] + 1);
            }
            Val1 = ascii[num1 - 1];
            Val2 = ascii[num2 - 1];
            Val3 = ascii[num3 - 1];
            Console.WriteLine(Val1 + " " + Val2 + " " + Val3);
        }
        public void carte(string num)
        {
            Random rnd = new Random();
            char[] ascii = new char[26];
            int num1;
            int num2;
            int num3;
            ascii[0] = 'a';
            for (int i = 1; i < ascii.Length; i++)
            {
                ascii[i] = Convert.ToChar(ascii[i - 1] + 1);
            }

            switch (num[0])
            {
                case '1':

                    if (num.Length == 2 && num[1] == '2')
                    {
                        num3 = rnd.Next(1, 27);
                        Val3 = ascii[num3 - 1];
                    }
                    else if (num.Length == 2 && num[1] == '3')
                    {
                        num2 = rnd.Next(1, 27);
                        Val2 = ascii[num2 - 1];
                    }
                    else
                    {
                        num2 = rnd.Next(1, 27);
                        num3 = rnd.Next(1, 27);
                        Val2 = ascii[num2 - 1];
                        Val3 = ascii[num3 - 1];
                    }
                    break;
                case '2':
                    if (num.Length == 2 && num[1] == '1')
                    {
                        num1 = rnd.Next(1, 27);
                        Val1 = ascii[num1 - 1];
                    }
                    else if (num.Length == 2 && num[1] == '3')
                    {
                        num1 = rnd.Next(1, 27);
                        Val1 = ascii[num1 - 1];
                    }
                    else
                    {
                        num1 = rnd.Next(1, 27);
                        num3 = rnd.Next(1, 27);
                        Val1 = ascii[num1 - 1];
                        Val3 = ascii[num3 - 1];
                    }
                    break;
                case '3':
                    if (num.Length == 2 && num[1] == '1')
                    {
                        num2 = rnd.Next(1, 27);
                        Val2 = ascii[num2 - 1];

                    }
                    else if (num.Length == 2 && num[1] == '2')
                    {
                        num1 = rnd.Next(1, 27);
                        Val1 = ascii[num1 - 1];
                    }
                    else
                    {
                        num1 = rnd.Next(1, 27);
                        num2 = rnd.Next(1, 27);
                        Val1 = ascii[num1 - 1];
                        Val2 = ascii[num2 - 1];
                    }

                    break;
            }


            Console.WriteLine(Val1 + " " + Val2 + " " + Val3);
        }
        public int cambioMonete()
        {
            int[] ascii = new int[26];
            bool cont = false;
            int num;
            ascii[0] = 97;
            for (int i = 1; i < ascii.Length; i++)
            {
                ascii[i] = ascii[i - 1] + 1;
            }
            //coppie
            if (Val1 == Val2 || Val2 == Val3 || Val1 == Val3)
            {
                Monete++;
            }
            //tris
            if (Val1 == Val2 && Val2 == Val3)
            {
                if (Val1 == 'z')
                {
                    Monete = Monete + jackpot;
                }
                else
                {
                    int i = 0;
                    while (cont == false)
                    {
                        if (Val1 == ascii[i])
                        {
                            cont = true;
                            num = i;
                            Monete += num;
                        }
                        else
                        {
                            i++;
                        }
                    }

                }
            }
            //consecutive
            if (Val1 == Val2 - 1 && Val2 == Val3 - 1)
            {
                Monete = Monete + 50;
            }
            return Monete;
        }

        }
    
}