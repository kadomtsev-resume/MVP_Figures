using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    //[SerializeField] private FigData _cubedata;
    //[SerializeField] private FigData _spheredata;
    //[SerializeField] private FigData _manycubedata;

    public Text infotext;

    //public string cubeinfo = "Это кубик!";
    //public string sphereinfo = "Это сфера!";
    //public string manycubes = "Кубик рубик?!";

    public void ChangeInfo(string figinfo)
    {
        infotext.text = figinfo;        //giving text info about figure
    }
}
