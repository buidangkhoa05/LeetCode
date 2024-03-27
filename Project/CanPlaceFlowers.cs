using System.Diagnostics.Contracts;

namespace _net_version;

public static class CanPlaceFlowerss
{
    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int count = 0;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] != 0)
            {
                continue;
            }
            var left = i - 1 < 0 ? 0 : flowerbed[i - 1];
            var right = i + 1 >= flowerbed.Length ? 0 : flowerbed[i + 1];

            if (left == 0 && right == 0)
            {
                flowerbed[i] = 1;
                count++;
            }
        }

        return count >= n;
    }
}
