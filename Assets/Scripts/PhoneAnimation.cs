using System.Linq;
using UnityEngine;

public class PhoneAnimation : MonoBehaviour
{
    [SerializeField]
    private GameObject[] screwObject, interactionObject, sliceOfMetal,phonehHandle;
    [SerializeField] private Dialog dialog;

    private int currentScrewDriver;
    private int currentInteraction;
    private bool hasAnswer;
    
    public void PlayAnimationScrew(GameObject screw)
    {
        for (int i = 0; i < 4; i++)
        {
            if(screwObject[i] == screw)
                screwObject[i].GetComponent<Animator>().enabled = true;
        }
        currentScrewDriver++;
    }
    
    public void PlayAnimationUnderPhone()
    {
        if (currentScrewDriver == 4)
        {
            interactionObject[currentInteraction].GetComponent<Animator>().enabled = true;
        }
    }

    public void PlayAnimationRemoveSliceOfMetal()
    {
        sliceOfMetal[currentInteraction].SetActive(false);
        dialog.ShowDialog(12);
    }

    public void PlayAnimationAnswerPhone()
    {
        phonehHandle[currentInteraction].GetComponent<Animator>().enabled = true;
        dialog.ShowDialog(13);
    }
}