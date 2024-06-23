using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class FlashlightToggle : MonoBehaviour
{
    public InputActionReference toggleFlashlightActionReference;
    public Light flashlight; // Make sure to assign this in the inspector

    private void OnEnable()
    {
        // Subscribe to the action's performed event
        toggleFlashlightActionReference.action.performed += ToggleFlashlight;
        toggleFlashlightActionReference.action.Enable();
    }

    private void OnDisable()
    {
        // Unsubscribe from the action's performed event
        toggleFlashlightActionReference.action.Disable();
        toggleFlashlightActionReference.action.performed -= ToggleFlashlight;
    }

    private void ToggleFlashlight(InputAction.CallbackContext context)
    {
        // Toggle the enabled state of the flashlight
        flashlight.enabled = !flashlight.enabled;
    }
}
