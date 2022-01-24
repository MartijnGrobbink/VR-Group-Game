using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{
    Animator animator;
    public GameObject menu1;
    public GameObject menu2;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.FindGameObjectsWithTag("Model")[0].GetComponent<Animator>();
    }
    
    public void OnAnimation1Press()
    {
        animator.Play("Jogging");
        menu1.SetActive(false);
        menu2.SetActive(true);
    }
    public void OnAnimation2Press()
    {
        animator.Play("IdleToPushUp");
        menu1.SetActive(false);
        menu2.SetActive(true);
    }
    public void OnAnimation3Press()
    {
        animator.Play("StartPlank");
        menu1.SetActive(false);
        menu2.SetActive(true);
    }
}
