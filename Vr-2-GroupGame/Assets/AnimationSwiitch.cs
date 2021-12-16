using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwiitch : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.FindGameObjectsWithTag("Model")[0].GetComponent<Animator>();
    }
    
    public void OnAnimation1Press()
    {
        animator.SetInteger("Animation", 0);
    }
    public void OnAnimation2Press()
    {
        animator.SetInteger("Animation", 1);
    }
    public void OnAnimation3Press()
    {
        animator.SetInteger("Animation", 2);
    }
}
