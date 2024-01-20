
using elettra.tegon._4i.SlotMachineLibreria;
using System.Text.RegularExpressions;
Console.WriteLine("Quante monete vuoi giocare?");
SlotMachineLib ogg = new SlotMachineLib(Convert.ToInt32(Console.ReadLine()));
string tieni;
char scelta;

if (ogg.Monete>0)
{   while(ogg.Monete > 0)
    {
        ogg.Monete--;
        for(int i = 0; i < 3; i++)
        {
            if(i==0)
            {
                ogg.carte();
            }
            Console.WriteLine("Se vuoi tenere una delle carte scegli 1 o 2 o 3, se ne vuoi scegliere due metti i numeri attaccati, altrimenti  scrivi 0");
            tieni=Console.ReadLine();
            if(tieni.Length<3 && Regex.IsMatch(tieni, "^[1,2,3]*$"))
            {
                
                ogg.carte(tieni);
                
            }
            else
            {
                ogg.carte();
            }
        }
        ogg.cambioMonete();
        Console.WriteLine("Vuoi riscuotere le monete? (y/n)");
        scelta=Convert.ToChar(Console.ReadLine());
        if(scelta=='y')
        {
            Console.WriteLine("Hai riscosso:" + ogg.Monete + "monete");
            ogg.Monete = 0;
        }
    }
}
else
{
    Console.WriteLine("Non ha più monete");
}