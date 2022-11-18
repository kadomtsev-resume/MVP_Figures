using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPresenter : MonoBehaviour
{
    [SerializeField]
    private InitUIButtons initUIButtons;

    [SerializeField]
    private Model model;

    [SerializeField]
    private FuncPresenter funcPresenter;

    private void Awake()
    {
        initUIButtons.OnButtonClick += ShowFig;
    }

    private void ShowFig(int id)
    {
        if (model.currFig != null)
        {
            model.currFig.SetActive(false);
        }

        model.allFigures[id].SetActive(true);

        model.currFig = model.allFigures[id];

        if (model.isSliced)
        {
            funcPresenter.DesBot();
            model.isSliced = false;
        }
    }

    private void OnDisable()
    {
        initUIButtons.OnButtonClick -= ShowFig;
    }
}
