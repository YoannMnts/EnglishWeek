using System;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    public bool isInteraction;
    [SerializeField] private Tool tool;
    public bool isScrewDriver;
    [SerializeField] private PhoneAnimation phoneAnimation;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && (isInteraction || isScrewDriver))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            {
                if(hit.collider.CompareTag("Interact") && isInteraction)
                {
                    phoneAnimation.PlayAnimationUnderPhone();
                }

                if (hit.collider.CompareTag("ScrewDriver") && isScrewDriver)
                {
                    phoneAnimation.PlayAnimationScrew(hit.collider.gameObject);
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
