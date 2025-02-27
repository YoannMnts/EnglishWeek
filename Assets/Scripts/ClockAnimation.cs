using UnityEngine;

public class ClockAnimation : MonoBehaviour
{
    [SerializeField] private Dialog dialog;
    void Start()
    {
        dialog.ShowDialog();
    }
}
