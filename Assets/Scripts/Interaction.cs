using System;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    public bool isInteraction;
    [SerializeField] private Tool tool;
    public bool isScrewDriver;
    [SerializeField] private PhoneAnimation phoneAnimation;
    [SerializeField] private ClockAnimation clockAnimation;
    [SerializeField] private Dialog dialog;
    private bool hasClickerOnBomb;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && (isInteraction || isScrewDriver))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            {
                
                if (hit.collider.CompareTag("ClockScrew") && isScrewDriver)
                {
                    clockAnimation.PlayAnimationScrew(hit.collider.gameObject);
                }

                if (hit.collider.CompareTag("ClockHatchBack") && isInteraction)
                {
                    clockAnimation.PlayAnimationHatch();
                }

                if (hit.collider.CompareTag("ClockButton") && isInteraction)
                {
                    clockAnimation.PlayAnimationClockButton();
                }

                if (hit.collider.CompareTag("Bomb") && isInteraction)
                {
                    if (hasClickerOnBomb == false)
                    {
                        dialog.ShowDialog();
                        hasClickerOnBomb = true;
                    }
                    else if (hasClickerOnBomb == true)
                    {
                        clockAnimation.showInputField();
                    }
                }

                if (hit.collider.CompareTag("Mecanism") && isInteraction)
                {
                    clockAnimation.PlayAnimationMecanism();
                }

                if (hit.collider.CompareTag("Key") && isInteraction)
                {
                    clockAnimation.GetKey();
                }

                if (hit.collider.CompareTag("HatchKey") && isInteraction)
                {
                    clockAnimation.PlayAnimationHatchKey();
                }

                if (hit.collider.CompareTag("Needle") && isInteraction)
                {
                    clockAnimation.showInputField();
                }

                if (hit.collider.CompareTag("Adress") && isInteraction)
                {
                    clockAnimation.Adress();
                }
                
                if(hit.collider.CompareTag("PhoneUnderCover") && isInteraction)
                { 
                    phoneAnimation.PlayAnimationUnderPhone();
                } 
                if (hit.collider.CompareTag("PhoneScrew") && isScrewDriver)
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
