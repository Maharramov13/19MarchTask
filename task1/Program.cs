using System.ComponentModel;

internal class Program
{
    public static void Main(string[] args)
    {
        
        int [] numbers1={12,34,5,6,13,27,44};
        int [] numbers2={36,85,5,34,2,90,88};
        System.Console.WriteLine("Birinci array");
        PrintArray(numbers1);
        System.Console.WriteLine("Ikinci array");
        PrintArray(numbers2);

        System.Console.WriteLine("Birinci array'de olub ikincide olmayan ededler");
        PrintDifference(numbers1,numbers2);
    }

    static void PrintArray(int[]arr){
        foreach(var item in arr){
            System.Console.WriteLine(item+ "");
        }
        System.Console.WriteLine();
    }

    static void PrintDifference(int[] arr1,int [] arr2)
    {
        foreach (var item in arr1)
        {
            if(!Contains(arr2,item))
            {
                System.Console.WriteLine(item +" ");
            }
            
        }
        static bool Contains(int[]arr,int element)
        {
            foreach(var item in arr){
                if(item==element){
                    return true;
                }
            }
            return false;
        }
    }
}
