using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedScript : MonoBehaviour
{
    public float AnimationSpeedValue;
    public float MaxAnimationSpeed;
    public float MinAnimationSpeed;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.FindGameObjectsWithTag("Model")[0].GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.speed = AnimationSpeedValue;
    }
    public void OnSpeedIncreaseButton()
    {
        if(AnimationSpeedValue < MaxAnimationSpeed)
        {
            AnimationSpeedValue += (float)0.1;
        }
    }
    public void OnSpeedDecreaseButton()
    {
        if (AnimationSpeedValue > MinAnimationSpeed)
        {
            AnimationSpeedValue -= (float)0.1;
        }
    }
}
