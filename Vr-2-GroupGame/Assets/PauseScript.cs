using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public bool paused;
    Animator animator;
    // Use this for initialization
    void Start () {
        paused = false;
        animator = GameObject.FindGameObjectsWithTag("Model")[0].GetComponent<Animator>();
    }
    
    public void PauseButtonPress(){
        paused = !paused;
        if (paused) {
            // Time.timeScale = 0;
            animator.enabled = false;
        } else if (!paused) {
            //Time.timeScale = 1;
            animator.enabled = true;
        }
    }
}
