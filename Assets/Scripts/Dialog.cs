using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    [SerializeField] private GameObject imgDialog;
    [SerializeField] private Sprite[] dialogSprite;

    public void ShowDialog(int index)
    {
        imgDialog.GetComponent<CanvasGroup>().alpha = 1;
        imgDialog.GetComponent<Image>().sprite = dialogSprite[index];
        StartCoroutine(WaitUntil());
    }

    IEnumerator WaitUntil()
    {
        yield return new WaitForSeconds(2f);
        imgDialog.GetComponent<CanvasGroup>().alpha = 0;
    }
}
