# VR_Practical_Test
**Code Analysis**
<br>



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

**Practical Test**
<br>
I have complete given work. As per instructions room, interactive objects, and interactive object should trigger an action. So I designed the room using BLENDER. In that room, plant pots are the interactive objects and when we grab of(interactive) those pots, turns into another color(triggers an action) and when we release a pot, then it will turn into original color. 

Interactive Object - **Plant Pots**
<br>
            Action - **Color Change**

