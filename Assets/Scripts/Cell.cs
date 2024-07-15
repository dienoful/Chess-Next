using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    private int x;
    private int y;

    public int X
    {
        set => x = value;
        get { return x; }
    }
    public int Y
    {
        set => y = value;
        get { return y; }
    }


    public void PrintPosition()
    {
        Debug.Log($"{X}, {Y}");
    }

    private void Awake()
    {
        
    }
}
