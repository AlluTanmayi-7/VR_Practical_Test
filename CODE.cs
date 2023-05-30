using UnityEngine;
using UnityEngine.XR;
public class VRInteractions : MonoBehaviour
{
    private bool isInteracting;

    private void Update()
    {
        if (isInteracting)
        {
            Debug.Log("Interacting with object.");
        }
        else
        {
            Debug.Log("Not interacting.");
        }
    }

    public void Interact()
    {
        isInteracting = !isInteracting;
    }
}