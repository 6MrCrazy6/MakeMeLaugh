using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour
{
    [SerializeField] private GameObject PreHistory;
    [SerializeField] private GameObject Pats1;

    [SerializeField] private GameObject panel;

    public void TransitionParts()
    {
        PreHistory.SetActive(false);
        Pats1.SetActive(true);
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Mouse0)) 
        {
            panel.SetActive(true);
        }
    }

    public void TransitionScene()
    {

    }
}
