using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoteteGan : MonoBehaviour
{
    void FixedUpdate()
    {
        RotetionGan();
    }
    private void RotetionGan()
    {
        Vector3 moveInput = Input.mousePosition;
        Vector3 difference = moveInput - Camera.main.WorldToScreenPoint(transform.position);
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(rotateZ - 90f, Vector3.forward);
    }
}
