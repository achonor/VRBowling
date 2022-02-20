using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RightHandController : MonoBehaviour, XRIDefaultInputActions.IXRIRightHandActions {
    private XRIDefaultInputActions controls;

    void OnEnable() {
        if (null == controls) {
            controls = new XRIDefaultInputActions();
            controls.XRIRightHand.SetCallbacks(this);
        }
        controls.XRIRightHand.Enable();
    }

    public void OnActivate(InputAction.CallbackContext context) {
    }

    public void OnActivateValue(InputAction.CallbackContext context) {
    }

    public void OnHapticDevice(InputAction.CallbackContext context) {
    }

    public void OnMove(InputAction.CallbackContext context) {
    }

    public void OnPosition(InputAction.CallbackContext context) {
    }

    public void OnPrimaryButtonPress(InputAction.CallbackContext context) {
        if (!context.performed) {
            return;
        }
        Debug.Log(message: "[Right Controller]: Primary Button Press!");
        BowlingManager.Instance.PlayBowlingDown();
    }

    public void OnRotateAnchor(InputAction.CallbackContext context) {
    }

    public void OnRotation(InputAction.CallbackContext context) {
    }

    public void OnSecondaryButtonPress(InputAction.CallbackContext context) {
        if (!context.performed) {
            return;
        }
        Debug.Log(message: "[Right Controller]: Secondary Button Press!");
        BowlingManager.Instance.PlayBowlingUp();
    }

    public void OnSelect(InputAction.CallbackContext context) {
    }

    public void OnSelectValue(InputAction.CallbackContext context) {
    }

    public void OnTeleportModeActivate(InputAction.CallbackContext context) {
    }

    public void OnTeleportModeCancel(InputAction.CallbackContext context) {
    }

    public void OnTeleportSelect(InputAction.CallbackContext context) {
    }

    public void OnTrackingState(InputAction.CallbackContext context) {
    }

    public void OnTranslateAnchor(InputAction.CallbackContext context) {
    }

    public void OnTurn(InputAction.CallbackContext context) {
    }

    public void OnUIPress(InputAction.CallbackContext context) {
    }

    public void OnUIPressValue(InputAction.CallbackContext context) {
    }

}
