using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject ball;
    public Transform Spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPress()
    {
        Instantiate(ball, Spawnpoint.transform.position, Quaternion.identity);
    }
}
