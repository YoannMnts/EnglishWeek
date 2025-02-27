using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    [SerializeField] private GameObject imgDialog;
    [SerializeField] private Sprite[] dialogSprite;
    private int index;

    public void ShowDialog()
    {
        imgDialog.GetComponent<CanvasGroup>().alpha = 1;
        imgDialog.GetComponent<Image>().sprite = dialogSprite[index];
        index++;
        StartCoroutine(WaitUntil());
    }

    IEnumerator WaitUntil()
    {
        yield return new WaitForSeconds(2f);
        imgDialog.GetComponent<CanvasGroup>().alpha = 0;
    }
}
