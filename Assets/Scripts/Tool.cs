using UnityEngine;
using UnityEngine.UI;

public class Tool : MonoBehaviour
{
    [SerializeField]
    private Glove glove;
    [SerializeField]
    private Interaction interaction;
    [SerializeField]
    private Button currentButton;

    public void ResetTool()
    {
        glove.isGlove = false;
        interaction.isInteraction = false;
        interaction.isScrewDriver = false;
        currentButton.interactable = true;
    }

    public void SetButtonDisable(Button button)
    {
        currentButton = button;
        currentButton.interactable = false;
    }
}
