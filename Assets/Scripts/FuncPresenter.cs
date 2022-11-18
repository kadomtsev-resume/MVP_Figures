using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class FuncPresenter : MonoBehaviour
{
    [SerializeField]
    private Model model;

    [SerializeField]
    private Material mat;

    [SerializeField]
    private int i;

    [SerializeField] private View _view;
    [SerializeField] private Model _model;
    [SerializeField] private Cut _cut;
    [SerializeField] private Decomposer _decomp;

    public void SliceButton()
    {
        if (CheckIsEmpty() || model.currFig.GetComponent<Decomposer>() != null)
            return;

        SliceFig(model.currFig);
        model.isSliced = true;
    }

    public void ComposeButton()
    {
        if(!CheckIsEmpty())
            Compose(model.currFig);
    }

    public void DecomposeButton()
    {
        if (!CheckIsEmpty())
            Decompose(model.currFig);
    }

    private void Compose(GameObject obj)
    {
        _decomp = obj.GetComponent<Decomposer>();
        if (_decomp != null)
            _decomp.ComposeBack(obj);
        else
            Debug.Log("Script for decompose wasn't found");
    }

    private void Decompose(GameObject obj)
    {
        _decomp = obj.GetComponent<Decomposer>();
        if (_decomp != null)
            _decomp.Decompose(obj);
        else
            Debug.Log("Script for decompose wasn't found");
    }

    private bool CheckIsEmpty()
    {
        if (model.currFig == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // ### SLICER ### // using "EzySlice" // It's slicing our figures!
    public void SliceFig(GameObject sliceobj)
    {
        if ((sliceobj != null || sliceobj.activeSelf) && i == 0)
        {
            SlicedHull Kesilen = Slice(sliceobj, mat);
            GameObject sliceup = Kesilen.CreateUpperHull(sliceobj, mat); // Creating upper part of slice
            sliceup.AddComponent<MeshCollider>().convex = true;
            sliceup.AddComponent<Rigidbody>();
            GameObject slicedown = Kesilen.CreateLowerHull(sliceobj, mat);  // Creating bottom part of slice
            slicedown.AddComponent<MeshCollider>().convex = true;
            sliceobj.SetActive(false);
            i = 1;
            StartCoroutine(DesCor(sliceup));
        }
        else
            Debug.Log("No slice obj or inactive or already sliced");
    }

    //This func setting parameters of slicer (global coord and etc)
    public SlicedHull Slice(GameObject obj, Material crossSectionMaterial = null)
    {
        return obj.Slice(transform.position, transform.right, crossSectionMaterial);
    }

    //destroying upper part of slice after N seconds
    IEnumerator DesCor(GameObject slup)
    {
        yield return new WaitForSeconds(1);
        Destroy(slup);
    }

    //destroying bottom part of slice when select any figure 
    public void DesBot()
    {
        if (GameObject.Find("Lower_Hull") != null)
        {
            Destroy(GameObject.Find("Lower_Hull"));
            i = 0;
        }
    }

    // ### END OF SLICER ###
}
