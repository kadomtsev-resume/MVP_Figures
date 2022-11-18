using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitUIButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject figureButtonPrefab;
    [SerializeField]
    private GameObject actionButtonPrefab;
    [SerializeField]
    private RectTransform placeOfSpawn;
    [SerializeField]
    private RectTransform actionsButtonToSpawn;
    [SerializeField]
    private Model model;

    public List<Button> figureButtons = new List<Button>();

    public Action<int> OnButtonClick;

    private void Start()
    {
        for (int i = 0; i < model.figData.Count; i++)
        {
            GameObject goButton = Instantiate(figureButtonPrefab, placeOfSpawn);
            goButton.GetComponentInChildren<Text>().text = model.figData[i].figName;

            if (goButton.GetComponentInChildren<Button>() != null)
            {
                figureButtons.Add(goButton.GetComponentInChildren<Button>());
            }
            else
            {
                Debug.Log("No Button");
            }
        }

        for (int i = 0; i < figureButtons.Count; i++)
        {
            int id = i;
            figureButtons[i].onClick.AddListener(delegate { ButtonClicked(id); });
        }

        //foreach (Button button in figureButtons)
        //{
        //    string str = "CLICK";
        //    button.onClick.AddListener(delegate { ButtonClicked(str); });
        //}
    }

    public void ButtonClicked(int id)
    {
        OnButtonClick?.Invoke(id);
    }
}
