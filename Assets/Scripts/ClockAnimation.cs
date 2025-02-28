using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClockAnimation : MonoBehaviour
{
    [SerializeField] private GameObject[] screwObject, interactionObject, clockButton, underClock, hatchSide, key, hatchKey, dial, inputField, keySound;
    [SerializeField] private Dialog dialog;
    private int currentScrewDriver;
    private int currentInteraction;
    private bool hasKey;
    void Start()
    {
        dialog.ShowDialog(0);
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
        dialog.ShowDialog(1);
    }

    public void PlayAnimationHatchSide()
    {
        hatchSide[currentInteraction].GetComponent<Animator>().enabled = true;
    }

    public void showInputField()
    {
        inputField[0].SetActive(true);
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
            }
        }
        inputField[0].SetActive(false);
    }

    public void PlayAnimationMecanism()
    {
        dialog.ShowDialog(4);
        key[currentInteraction].SetActive(true);
        keySound[0].SetActive(true);
    }

    public void GetKey()
    {
        key[currentInteraction].SetActive(false);
        hasKey = true;
        dialog.ShowDialog(5);
    }

    public void PlayAnimationHatchKey()
    {
        hatchKey[currentInteraction].GetComponent<Animator>().enabled = true;
        dialog.ShowDialog(6);
    }

    public void PlayAnimationDial()
    {
        dial[currentInteraction].GetComponent<Animator>().enabled = true;
    }

    public void Adress()
    {
        dialog.ShowDialog(7);
        SceneManager.LoadScene(2);
    }
}
