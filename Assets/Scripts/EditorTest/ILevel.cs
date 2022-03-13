using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILevel
{
    int Exp { get; set; }
    int level { get; }
    void AddExp(int num);
}
