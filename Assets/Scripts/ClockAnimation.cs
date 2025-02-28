using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClockAnimation : MonoBehaviour
{
    [SerializeField] private GameObject[] screwObject, interactionObject, clockButton, underClock, hatchSide, key, hatchKey, dial;
    [SerializeField] private Dialog dialog;
    private int currentScrewDriver;
    private int currentInteraction;
    private bool hasKey;
    void Start()
    {
        dialog.ShowDialog();
    }
    
    public void PlayAnimationScrew(GameObject screw)
    {
        for (int i = 0; i < 4; i++)
        {
            if(screwObject[i] == screw)
                screwObject[i].GetComponent<Animator>().enabled = true;
        }
        currentScrewDriver++;
    }
    public void PlayAnimationHatch()
    {
        if (currentScrewDriver == 4)
        {
            interactionObject[currentInteraction].GetComponent<Animator>().enabled = true;
        }
    }

    public void PlayAnimationClockButton()
    {
        clockButton[currentInteraction].GetComponent<Animator>().enabled = true;
        underClock[currentInteraction].SetActive(false);
        dialog.ShowDialog();
    }

    public void PlayAnimationHatchSide()
    {
        hatchSide[currentInteraction].GetComponent<Animator>().enabled = true;
    }

    public void showInputField()
    {
        this.gameObject.SetActive(true);
    }
    public void codeEntry(String hour)
    {
        if (hasKey)
        {
            if (hour == "1846")
            {
                PlayAnimationDial();
            }
        }
        else
        {
            if (hour == "4751")
            {
                PlayAnimationHatchSide();
                dialog.ShowDialog();
            }
        }
        this.gameObject.SetActive(false);
    }

    public void PlayAnimationMecanism()
    {
        dialog.ShowDialog();
        key[currentInteraction].SetActive(true);
    }

    public void GetKey()
    {
        key[currentInteraction].SetActive(false);
        hasKey = true;
    }

    public void PlayAnimationHatchKey()
    {
        hatchKey[currentInteraction].GetComponent<Animator>().enabled = true;
        dialog.ShowDialog();
    }

    public void PlayAnimationDial()
    {
        dial[currentInteraction].GetComponent<Animator>().enabled = true;
    }

    public void Adress()
    {
        dialog.ShowDialog();
        SceneManager.LoadScene(2);
    }
}
