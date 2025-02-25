using UnityEngine;

public class Tool : MonoBehaviour
{
    [SerializeField]
    private Glove glove;
    [SerializeField]
    private Interaction interaction;

    public void ResetTool()
    {
        glove.isGlove = false;
        interaction.isInteraction = false;
        interaction.isScrewDriver = false;
    }
}
