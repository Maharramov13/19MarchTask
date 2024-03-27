internal class Program
{
    public static void Main(string[] args)
    {
        /*
Asagidaki member-lerden ibaret User class-i yaradin:

UserName - istifadeci adini ifade edir
Password - istifadeci sifresini ifade edir

UserName deyeri teyin olunmamis User obyekti yaradila bilinmemelidir. 
UserName deyerinin uzunlugu minimum 8 olmalidr.
Password deyerinin uzunlugu minimum 8 olmalidir ve icinde en az 1 boyuk herf,1 kicik herf ve 1 reqem olmalidir.
Eks teqdirde password deyeri set oluna bilinmemelidir. */

        User user =new User("Turan ","Fenerbahce1");
        // user.ContainsTolower("Turan Maharramov");
         //user.ContainsUpperCase("Turan Maharramov");
         //user.ContainsDigit("Fenerbahce");
        System.Console.WriteLine(user.UserName);


    }
}