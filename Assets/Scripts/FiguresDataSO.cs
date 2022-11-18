using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FigureDataSO", menuName = "FigureDataSO")]

public class FiguresDataSO : ScriptableObject
{
    public List<string> figureName = new List<string>();
    public List<string> figureDescription = new List<string>();
    public List<GameObject> figures = new List<GameObject>();
}
