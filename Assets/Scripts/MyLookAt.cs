using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLookAt : MonoBehaviour
{
    public Transform target;
    public float viewingAngle = 70.0f;
    void Update()
    {
        Vector3 forward = transform.forward;
        Vector3 toTarget = target.position - transform.position;

        float dot = Vector3.Dot(forward, toTarget); // +면 앞, -면 뒤에있는 것
        float angle = Mathf.Acos(dot / toTarget.magnitude); // 타겟의 각도 구하기

        Debug.Log($"angle : {angle * Mathf.Rad2Deg}");

        //if(Vector3.Dot(transform.right, toTarget) >= 0.0f)  // +면 오른쪽, -면 왼쪽에 있는 것
        //{
        //    transform.rotation = transform.rotation * Quaternion.Euler(0f, angle, 0f);
        //}
        //else
        //{
        //    transform.rotation = transform.rotation * Quaternion.Euler(0f, -angle, 0f);
        //}

        if(angle * Mathf.Rad2Deg < viewingAngle) // 타겟과의 각도가 시야각보다 작아지면 바라보기
        {
            Debug.Log("TargetCheck!!!");
            if (Vector3.Dot(transform.right, toTarget) >= 0.0f)  // +면 오른쪽, -면 왼쪽에 있는 것
            {
                transform.rotation = transform.rotation * Quaternion.Euler(0f, angle, 0f);
            }
            else
            {
                transform.rotation = transform.rotation * Quaternion.Euler(0f, -angle, 0f);
            }
        }
    }
}
