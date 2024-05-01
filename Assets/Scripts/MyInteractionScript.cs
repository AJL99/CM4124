using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MyInteractionScript : MonoBehaviour
{
    // Reference to the XR Simple Interactable component
    private XRBaseInteractable interactable;

    private void Start()
    {
        // Get the XR Simple Interactable component on this object
        interactable = GetComponent<XRBaseInteractable>();

        // Subscribe to the interaction events
        interactable.onSelectEntered.AddListener(OnSelectEnter);
        interactable.onSelectExited.AddListener(OnSelectExit);
    }

    private void OnSelectEnter(XRBaseInteractor interactor)
    {
        // Handle trigger press (e.g., activate a script)
        Debug.Log("Trigger pressed! Activate your custom behavior here.");
        // Add your custom logic here (e.g., call a method, enable/disable something, etc.)
    }

    private void OnSelectExit(XRBaseInteractor interactor)
    {
        // Handle trigger release (if needed)
    }
}
