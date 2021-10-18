using UnityEngine;
using System;

public class ArrayMap : MonoBehaviour
{
    private int[,] mapArray;

    [SerializeField] private Sprite mapSprite;

    void Start()
    {

    }

    public int[,] ConvertSpriteToArrayMap()
    {
        mapArray = new int[mapSprite.texture.width, mapSprite.texture.height];
        for (int y = 0; y < mapSprite.texture.height ; y++)
        {
            for (int x = 0; x < mapSprite.texture.width; x++)
            {
                Color textureColor = mapSprite.texture.GetPixel(x, mapSprite.texture.height - (y + 1));

                if (textureColor.a == 0)
                {
                    mapArray[y, x] = 0;
                }
                else
                {
                    mapArray[y, x] = 1;
                }
            }
        }

        PrintArray(mapArray);
        return mapArray;
    }

    private void AddBounds()
    {
        
    }

    private void PrintArray(int[,] array)
    {
        string result = "";
        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            result += "\n";
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                result += $"{array[i, j]} ";       
            }
            
        }

        Debug.Log(result);
    }
}
