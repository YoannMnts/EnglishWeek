using System.Linq;
using UnityEngine;

public class PhoneAnimation : MonoBehaviour
{
    [SerializeField]
    private GameObject[] screwObject, interactionObject;
    

    private int currentScrewDriver;
    private int currentInteraction;
    
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
}