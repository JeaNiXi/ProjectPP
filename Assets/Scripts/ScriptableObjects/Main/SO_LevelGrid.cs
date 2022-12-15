using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Empty Level",menuName = "Levels/New Level")]
public class SO_LevelGrid : ScriptableObject
{
    public int Width;
    public int Height;
    public bool[,] GridData;
}


