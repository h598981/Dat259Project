using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Lighter : XRGrabInteractable
{
    public GameObject flameEffect;  // The visual effect for the lighter's flame.
    public InputActionReference toggleAction;  // The input action to toggle the flame.
    public bool isLit = false;  // Indicates if the lighter is currently lit.

    protected override void OnEnable()
    {
        base.OnEnable();
        toggleAction.action.Enable();
        toggleAction.action.performed += ToggleFlame;
    }

    protected override void OnDisable()
    {
        toggleAction.action.Disable();
        toggleAction.action.performed -= ToggleFlame;
        base.OnDisable();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        // Signal that the lighter is held.
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        // Automatically turn off the lighter when it's not held.
        isLit = false;
        flameEffect.SetActive(false);
    }

    private void ToggleFlame(InputAction.CallbackContext context)
    {
        // Only allow toggling if the lighter is currently being held.
        if (isSelected)
        {
            isLit = !isLit;
            flameEffect.SetActive(isLit);
            Debug.Log($"Lighter toggled: {isLit}");
        }
    }
}
