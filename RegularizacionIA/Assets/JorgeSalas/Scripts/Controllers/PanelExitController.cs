using System;
using UnityEngine;

public class PanelExitController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            PanelManagerController.Instance.panelExit.SetActive(true);
        }
    }
}
