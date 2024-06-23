using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class DiaryInteraction : XRGrabInteractable
{
    public InputActionReference toggleFlashlightReference;
    public GameObject textCanvas;

    private bool isHeld = false; // State to track whether the diary is held

    protected override void OnEnable()
    {
        base.OnEnable();
        toggleFlashlightReference.action.Enable();
        toggleFlashlightReference.action.performed += ToggleCanvas;
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        toggleFlashlightReference.action.Disable();
        toggleFlashlightReference.action.performed -= ToggleCanvas;
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        isHeld = true;  // Set the flag when the diary is grabbed
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        isHeld = false;  // Clear the flag when the diary is released
    }

    private void ToggleCanvas(InputAction.CallbackContext context)
    {
        Debug.Log("Input action triggered");
        if (isHeld) // Check if the diary is currently held
        {
            Debug.Log($"Diary is held: {isHeld}, toggling canvas");
            textCanvas.SetActive(!textCanvas.activeSelf);
        }
        else
        {
            Debug.Log("Diary is not held, not toggling canvas");
        }
    }



}
