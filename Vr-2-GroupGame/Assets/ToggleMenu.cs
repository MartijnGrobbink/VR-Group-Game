using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleMenu : MonoBehaviour
{
    public InputActionReference toggleButtonReference = null;
    GameObject player;
    bool isActive;
    private void Awake()
    {
        toggleButtonReference.action.started += Toggle;
        player = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void OnDestroy()
    {
        toggleButtonReference.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        //when the button is pressed show the menu and lock the location of the menu
         isActive = !gameObject.activeSelf;
         gameObject.SetActive(isActive);

        if(isActive == true)
        {
            transform.position = new Vector3(0, 0, 1);
            transform.SetParent(player.transform, false);
            //setting it to the camera and then removing it so that it stays in the scene
            Vector3 temp = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
            transform.SetParent(null);
            transform.position = temp;

            //setting it up so that the menu looks at the player
            transform.LookAt(player.transform);
            //the menu was mirrored so this is that the menu is turned the right way
            transform.localRotation = Quaternion.Euler(0, transform.eulerAngles.y + 180, 0);
        }
    }

    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        //when the player moves to much make the menu disapear
        if(dist > (float)1.3)
        {
            isActive = false;
            gameObject.SetActive(isActive);
         }
    }
}