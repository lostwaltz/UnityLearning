using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintLayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LayerMask maskPlayer = LayerMask.GetMask("Player");
        LayerMask maskMonster = LayerMask.GetMask("Monster");

        Debug.Log(maskPlayer.value);
        Debug.Log(maskMonster.value);


        int playerBinaryValue = CalculateBinary(maskPlayer.value);
        int monsterBinaryValue = CalculateBinary(maskMonster.value);

        Debug.Log(playerBinaryValue);
        Debug.Log(monsterBinaryValue);
    }

    private int CalculateBinary(int number)
    {
        Queue<int> binaryValue = new Queue<int>();


        bool isDone = false;
        while(!isDone)
        {
            binaryValue.Enqueue(number % 2);
            number = number / 2;

            if(number == 0)
            {
                isDone = true;
            }
        }

        int count = binaryValue.Count;
        int value = 0;
        int multiplier = 1;
        for (int i = 0; i < count; i++)
        {
            value += binaryValue.Dequeue() * multiplier;
            multiplier = multiplier * 10;
        }

        return value;
    }
}
