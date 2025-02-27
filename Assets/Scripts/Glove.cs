using System;
using UnityEngine;
using UnityEngine.UI;

public class Glove : MonoBehaviour
{
    [SerializeField]
    private float PCRotationSpeed;
    [SerializeField]
    private float MobileRotationSpeed;
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private Tool tool;
    public bool isGlove = false;

    private void OnMouseDrag()
        {
            if (isGlove)
            {
                float rotx = Input.GetAxis("Mouse X") * PCRotationSpeed;
                float roty = Input.GetAxis("Mouse Y") * PCRotationSpeed;
        
                Vector3 right = Vector3.Cross(cam.transform.up, transform.position - cam.transform.position);
                Vector3 up = Vector3.Cross(transform.position - cam.transform.position, right);
                transform.rotation = Quaternion.AngleAxis(-rotx, up) * transform.rotation;
                transform.rotation = Quaternion.AngleAxis(roty, right) * transform.rotation;
            }
        }
    public void ButtonGloveClick(Button button)
        {
            tool.ResetTool();
            isGlove = true;
            tool.SetButtonDisable(button);
        }
}