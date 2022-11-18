using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class Presenter : MonoBehaviour
{
    [SerializeField] private GameObject currentfig;

    [SerializeField] private View _view;
    [SerializeField] private Model _model;
    [SerializeField] private Cut _cut;
    [SerializeField] private Decomposer _decomp;

    // ### FUNCTIONS ###

    //disabling figure if it's active
    private void checkfig()
    {
        if (currentfig != null)
            currentfig.SetActive(false);
    }

    //Activating selected figure, resetting parameters
    //private void ShowFig(GameObject obj)
    //{
    //    ResetCompose(currentfig);   //reseting the decompose of figure when selecting other fig
    //    checkfig();                 //disabling previous figure
    //    obj.SetActive(true);        //activating selected figure
    //    currentfig = obj;           //temp param, used to know which figure is selected
    //    DesBot();                   //destoy lower_hull
    //    //ChangeInfo(currentfig.GetComponent<CurParam>().figdata.FigInfo);
    //}

    //Changing text info about figure
    private void ChangeInfo(string figinfo)
    {
        _view.ChangeInfo(figinfo);
    }

    //Slicing the figure
    //private void SliceFig(GameObject obj)
    //{
    //    if (currentfig.transform.childCount == 0)
    //        _model.SliceFig(obj);
    //    else
    //        Debug.Log("Too hard to slice, need to unite meshes!");
    //}

    // Two in one! Activating figure + changing info
    //private void NewFig(GameObject obj)
    //{
    //    ShowFig(obj);
    //}

    //destroy lower_hull after slice
    //private void DesBot()
    //{
    //    _model.DesBot();
    //}

    //decomposing the figure
    private void Decompose(GameObject obj)
    {
        _decomp = currentfig.GetComponent<Decomposer>();
        if (_decomp != null)
            _decomp.Decompose(obj);
        else
            Debug.Log("Script for decompose wasn't found");
    }

    //composing the figure back
    private void Compose(GameObject obj)
    {
        _decomp = currentfig.GetComponent<Decomposer>();
        if (_decomp != null)
            _decomp.ComposeBack(obj);
        else
            Debug.Log("Script for decompose wasn't found");
    }

    //resetting the decomposition
    private void ResetCompose(GameObject obj) 
    {
        if (_decomp != null)
            _decomp.ResetCompose(obj);
    }

    // ### END OF FUNCTIONS ###

    // ### BUTTONS ### //here we check button clicks and do what is clicked

    // CUBE
    public void CubeButton()
    {
        //NewFig(_model.cube);
    }

    //SPHERE
    public void SphereButton()
    {
        //NewFig(_model.sphere);
    }

    //27 CUBES
    public void ManyCubesButton()
    {
        //NewFig(_model.manycubes);
    }

    //Slicing the figure
    //public void SliceButton()
    //{
    //    if (currentfig != null)
    //    {
    //        SliceFig(currentfig);
    //    }
    //    else
    //    {
    //        Debug.Log("Currentfig is null");
    //    }
    //}

    //Decomposing the figure
    public void DecomposeButton()
    {
        if (currentfig != null)
        {
            Decompose(currentfig);
        }
        else
        {
            Debug.Log("Currentfig is null");
        }
    }

    //Composing the figure
    public void ComposeButton()
    {
        if (currentfig != null)
            Compose(currentfig);
        else
            Debug.Log("Currentfig is null");

    }

    //### END OF BUTTONS ###
}
