using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FigureData", menuName = "Figure Data", order = 51)]

public class FigData : ScriptableObject
{
    public string figName;
    public string figInfo;
    public GameObject figPrefab;
}
