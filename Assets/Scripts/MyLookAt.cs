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

        float dot = Vector3.Dot(forward, toTarget); // +�� ��, -�� �ڿ��ִ� ��
        float angle = Mathf.Acos(dot / toTarget.magnitude); // Ÿ���� ���� ���ϱ�

        Debug.Log($"angle : {angle * Mathf.Rad2Deg}");

        //if(Vector3.Dot(transform.right, toTarget) >= 0.0f)  // +�� ������, -�� ���ʿ� �ִ� ��
        //{
        //    transform.rotation = transform.rotation * Quaternion.Euler(0f, angle, 0f);
        //}
        //else
        //{
        //    transform.rotation = transform.rotation * Quaternion.Euler(0f, -angle, 0f);
        //}

        if(angle * Mathf.Rad2Deg < viewingAngle) // Ÿ�ٰ��� ������ �þ߰����� �۾����� �ٶ󺸱�
        {
            Debug.Log("TargetCheck!!!");
            if (Vector3.Dot(transform.right, toTarget) >= 0.0f)  // +�� ������, -�� ���ʿ� �ִ� ��
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
