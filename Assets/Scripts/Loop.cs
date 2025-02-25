using UnityEngine;

public class Loop : MonoBehaviour
{
    private int flipFlop;
    private float zoom = 2.5f;
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            if (flipFlop == 0)
            {
                transform.localPosition += new Vector3(0, 0, zoom);
                flipFlop++;
            }
            else if (flipFlop == 1)
            {
                transform.localPosition += new Vector3(0, 0, -zoom);
                flipFlop--;
            }
            
        }
    }
}
