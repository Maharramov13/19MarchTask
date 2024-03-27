using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static void Main(string[] args)
    {
        /*Task - 4
CalcAvg metodu - Gonderilmis imtahanlar qiymeti siyahisina (integer array) esasen hemin qiymetlerin ortalamasini qaytaran
 metod yazin. Main metodunda bu metodu call edib, burdan qayidan deyere esasen ortalama 60-dan boyukdursa 
 console-da "mezun oldunuz" eks halda 
"mezun ola bilmediniz" yazisi yazdirin */

System.Console.WriteLine("Ortalama puaninizi gormek ucun puanlari daxil edin");
int count=Convert.ToInt16(Console.ReadLine());

int []grades=new int [count];

for (int i = 0; i < count; i++)
{
    System.Console.WriteLine($"puan {i+1}: ");
    grades[i]=Convert.ToInt16(Console.ReadLine());
}


    }

    public static double CalcAvg(int [] grades){
        int sum=0;
        foreach(int grade in grades){
            sum+=grade;
        }
        return(double) sum/grades.Length;
    }
}