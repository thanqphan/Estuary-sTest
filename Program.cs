// See https://aka.ms/new-console-template for more information
using System.Text;

int[] arr1 = { 1, 2, 3 };
int[] arr2 = { 2, 7, 4, 1, 8, 11 };

Console.WriteLine("Last stone of arr1" + SmashStone(arr1));
Console.WriteLine("Last stone of arr2" + SmashStone(arr2));

int SmashStone(int[] arr)
{
    if (arr.Length == 0) return 0;

    var stones = arr.ToList();
    while (stones.Count > 1)
    {
        stones.Sort((a, b) => b - a);
        //max
        int y = stones[0];
        //2-max
        int x = stones[1];
        //remove 2 stones max n 2-max in array
        stones.RemoveAt(0);
        stones.RemoveAt(0);

        if (x != y)
        {
            stones.Add(y - x);
            //still have stones
        }
    }

    return stones.Count == 0 ? 0 : stones[0];
}