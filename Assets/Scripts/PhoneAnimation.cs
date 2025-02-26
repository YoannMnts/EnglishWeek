using UnityEngine;

public class PhoneAnimation : MonoBehaviour
{
    [SerializeField]
    private GameObject[] phone;

    private int currentObject;

    public void PlayAnimation()
    {
        phone[currentObject].GetComponent<Animator>().enabled = true;
        currentObject++;
    }
}
