using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [ContextMenuItem("RandomExp", "RandomExp")]
    public int exp;

    private int level;

    public int Level { get => exp / 500; set => level = value; }

    public void AddExp(int addNum)
    {
        exp += addNum;
    }

    [ContextMenu("Reset Exp")]
    private void ResetExp()
    {
        exp = 0;
    }

    private void RandomExp()
    {
        exp = Random.Range(0, 10000);
    }

}
