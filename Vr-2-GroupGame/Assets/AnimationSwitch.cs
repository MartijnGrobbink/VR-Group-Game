using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.FindGameObjectsWithTag("Model")[0].GetComponent<Animator>();
    }
    
    public void OnAnimation1Press()
    {
        animator.Play("Jogging");
    }
    public void OnAnimation2Press()
    {
        animator.Play("IdleToPushUp");
    }
    public void OnAnimation3Press()
    {
        animator.Play("StartPlank");
    }
}
