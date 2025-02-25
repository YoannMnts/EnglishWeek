using System;
using UnityEngine;
using UnityEngine.UI;

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
    
    public void ButtonInteractionClick(Button button)
    {
        tool.ResetTool();
        isInteraction = true;
        tool.SetButtonDisable(button);
    }
    
    public void ButtonScrewDriverClick(Button button)
    {
        tool.ResetTool();
        isScrewDriver = true;
        tool.SetButtonDisable(button);
    }
}
