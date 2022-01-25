using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenu : MonoBehaviour
{
    public GameObject closemenu;
    public GameObject StartMenu;
    public GameObject CanvasMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ExitButtonPress()
    {
        closemenu.SetActive(false);
        StartMenu.SetActive(true);
        CanvasMenu.SetActive(false);
    }
}
