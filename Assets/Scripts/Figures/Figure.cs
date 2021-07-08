using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Figure
{
    //TODO bool CanMove(Cell d)
    //TODO List<cell> movements
    public string Name;
    public abstract List<List<(int, int)>> GetRelativeMoves((int, int) size);//!should be written in (x, y) format

    public Figure(string name)
    {
        Name = name;
    }


}