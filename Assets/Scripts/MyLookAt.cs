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

        float dot = Vector3.Dot(forward, toTarget); // +�� ��, -�� �ڿ��ִ� ��
        float angle = Mathf.Acos(dot / toTarget.magnitude); // Ÿ���� ���� ���ϱ�

        Debug.Log($"angle : {angle * Mathf.Rad2Deg}");
    }
}
