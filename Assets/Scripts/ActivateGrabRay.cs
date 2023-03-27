using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateGrabRay : MonoBehaviour
{
    [SerializeField] GameObject leftGrabRay;
    [SerializeField] GameObject rightGrabRay;

    public XRDirectInteractor _leftDirectGrab;
    public XRDirectInteractor _rightDirectGrab;

    private void Update()
    {
        leftGrabRay.SetActive(_leftDirectGrab.interactablesSelected.Count == 0);
        rightGrabRay.SetActive(_rightDirectGrab.interactablesSelected.Count == 0);
    }
}
