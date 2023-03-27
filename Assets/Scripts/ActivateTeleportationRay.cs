using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    [SerializeField] GameObject _leftTeleportation;
    [SerializeField] GameObject _rightTeleportation;

    [SerializeField] InputActionProperty _leftTeloportBtn;
    [SerializeField] InputActionProperty _rightTeloportBtn;

    [SerializeField] InputActionProperty _leftGrabBtn;
    [SerializeField] InputActionProperty _rightGrabBtn;

    private void Update()
    {
        _leftTeleportation.SetActive(_leftGrabBtn.action.ReadValue<float>() == 0 && _leftTeloportBtn.action.ReadValue<float>() > 0.1f);
        _rightTeleportation.SetActive(_rightGrabBtn.action.ReadValue<float>() == 0 && _rightTeloportBtn.action.ReadValue<float>() > 0.1f);
    }

}
