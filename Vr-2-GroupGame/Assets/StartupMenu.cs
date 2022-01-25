using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupMenu : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SwitchPress()
    {
        menu1.SetActive(false);
        menu2.SetActive(true);
    }
}
