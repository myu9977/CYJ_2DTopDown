using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWindowController : MonoBehaviour
{
    public GameObject choicePanel;

    void Start()
    {
        choicePanel.SetActive(false);
    }

    public void OpenPanel()
    {
        choicePanel.SetActive(true);
    }


}
