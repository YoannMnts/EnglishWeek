using System;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public bool isInteraction;
    [SerializeField] private Tool tool;
    public bool isScrewDriver;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && (isInteraction || isScrewDriver))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            {
                if(hit.collider.CompareTag("Interact") && isInteraction || hit.collider.CompareTag("ScrewDriver") && isScrewDriver)
                {
                    hit.transform.GetComponent<Animator>().enabled = true;
                }
            }
        }
    }
    
    public void ButtonInteractionClick()
    {
        tool.ResetTool();
        isInteraction = true;
    }
    
    public void ButtonScrewDriverClick()
    {
        tool.ResetTool();
        isScrewDriver = true;
    }
}
