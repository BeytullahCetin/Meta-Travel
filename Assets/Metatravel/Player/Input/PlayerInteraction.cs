using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;


    public void OnInteractionInput(InputAction.CallbackContext context)
    { 
        if (context.performed && mainCamera.GetComponent<CameraRaycast>().isHitButton)
        {

            if (mainCamera.GetComponent<CameraRaycast>().whichButton.CompareTag("Button1"))
            {
                //mainCamera.GetComponent<CameraRaycast>().whichButton.GetComponent<ButtonPressed>().Pressed();
                Debug.Log("1. button i�in url yi buraya yap��t�r.");
            }
            else if (mainCamera.GetComponent<CameraRaycast>().whichButton.CompareTag("Button2"))
                Debug.Log("2. button i�in url yi buraya yap��t�r.");
            else if (mainCamera.GetComponent<CameraRaycast>().whichButton.CompareTag("Computer"))
            {

            }
        }
    }
}
