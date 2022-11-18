using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class Model : MonoBehaviour
{
    [SerializeField]
    public Transform spawnPoint;
    public List<FigData> figData = new List<FigData>();
    public List<GameObject> allFigures = new List<GameObject>();

    [Space]

    [Header("Slicer parameters")]
    public Material mat;
    public GameObject sliceobj;
    public bool isSliced = false;

    public int i = 0;

    [Space]
    public GameObject currFig = null;

    private void Awake()
    {
        for (int i = 0; i < figData.Count; i++)
        {
            GameObject goFig = Instantiate(figData[i].figPrefab, spawnPoint);
            goFig.SetActive(false);

            allFigures.Add(goFig);
        }
    }
}
