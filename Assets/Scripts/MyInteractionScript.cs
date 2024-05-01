using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;

public class MyInteractionScript : MonoBehaviour
{
    private XRBaseInteractable interactable;
    private AudioSource audioSource;
    private bool isCooldownActive = false;

    private void Start()
    {
        interactable = GetComponent<XRBaseInteractable>();
        audioSource = GetComponent<AudioSource>();

        // Subscribe to the interaction events
        interactable.onSelectEntered.AddListener(OnSelectEnter);
    }

    private void OnSelectEnter(XRBaseInteractor interactor)
    {
        if (!isCooldownActive)
        {
            // Play the sound
            audioSource.Play();

            // Add your custom logic here (if needed)
            // For example:
            // YourCustomBehavior();

            // Start the cooldown coroutine
            StartCoroutine(StartCooldown());
        }
    }

    private IEnumerator StartCooldown()
    {
        // Set the cooldown flag
        isCooldownActive = true;

        // Wait for 4 seconds
        yield return new WaitForSeconds(4f);

        // Reset the cooldown flag
        isCooldownActive = false;
    }

}