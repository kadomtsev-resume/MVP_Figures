using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInfoPresenter : MonoBehaviour
{
    [SerializeField]
    private InitUIButtons initUIButtons;

    [SerializeField]
    private Model model;

    [SerializeField]
    private Text text = null;

    private void Awake()
    {
        initUIButtons.OnButtonClick += ChangeText;
    }

    private void ChangeText(int id)
    {
        text.text = model.figData[id].figInfo;
    }

    private void OnDisable()
    {
        initUIButtons.OnButtonClick -= ChangeText;
    }
}
