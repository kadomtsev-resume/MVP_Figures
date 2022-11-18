using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class Cut : MonoBehaviour
{
    [SerializeField] public Material mat;
    [SerializeField] public GameObject sliceobj;

    public void CutTheFig(GameObject sliceobj)
    {
        SlicedHull Kesilen = Slice(sliceobj, mat);
        GameObject sliceup = Kesilen.CreateUpperHull(sliceobj, mat);
        sliceup.AddComponent<MeshCollider>().convex = true;
        sliceup.AddComponent<Rigidbody>();
        GameObject slicedown = Kesilen.CreateLowerHull(sliceobj, mat);
        slicedown.AddComponent<MeshCollider>().convex = true;
        sliceobj.SetActive(false);
    }

    public SlicedHull Slice(GameObject obj, Material crossSectionMaterial = null)
    {
        return obj.Slice(transform.position, transform.right, crossSectionMaterial);
    }
}
