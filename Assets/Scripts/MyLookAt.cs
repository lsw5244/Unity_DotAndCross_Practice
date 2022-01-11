using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLookAt : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        Vector3 forward = transform.forward;
        Vector3 toTarget = target.position - transform.position;

        float dot = Vector3.Dot(forward, toTarget); // +면 앞, -면 뒤에있는 것
        float angle = Mathf.Acos(dot / toTarget.magnitude); // 타겟의 각도 구하기

        Debug.Log($"angle : {angle * Mathf.Rad2Deg}");
    }
}
