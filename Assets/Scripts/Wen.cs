using UnityEngine;
using UnityEngine.UI;

public class Wen : MonoBehaviour
{
    private int flipFlop;
    private float zoom = 2.5f;

    public void ButtonWenClick()
    {
        if (flipFlop == 0)
        {
            transform.localPosition += new Vector3(0, 0, zoom);
            flipFlop++;
        }
        else if (flipFlop == 1)
        {
            transform.localPosition -= new Vector3(0, 0, zoom);
            flipFlop--;
        }
    }
}
