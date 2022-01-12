using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooAtPr : MonoBehaviour
{
    public Transform target;
    public float viewAngle = 70.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 foward = transform.forward;
        Vector3 toOther = target.position - transform.position;

        // �������� ���ϱ�
        Vector3 normalVec = Vector3.Cross(foward, toOther);

        // ���� �� ���� �۷ι� up�� �������� �� �а�(����) = ����, ����(������) = ���
        if (Vector3.Dot(Vector3.up, normalVec) < 0f)
        {
            Debug.Log("�÷��̾ ���ʿ� ����");
        }
        else
        {
            Debug.Log("�÷��̾ �����ʿ� ����");
        }
    
        //float dot = Vector3.Dot(foward, target.position);

        //float angle = Mathf.Acos(dot / toOther.magnitude);

        /* Vector3 cross = Vector3.Cross(toOther, foward);

         Debug.Log($"x : {cross.x}, y : {cross.y}, z : {cross.z}");

         Debug.Log("dot : " + Vector3.Dot(Vector3.up, cross));*/


        //if(angle * Mathf.Rad2Deg < viewAngle)
        //{
        //    if (Vector3.Dot(transform.right, target.position) >= 0)
        //    {
        //        transform.rotation = transform.rotation * Quaternion.Euler(0f, angle, 0f);
        //    }
        //    else
        //    {
        //        transform.rotation = transform.rotation * Quaternion.Euler(0f, -angle, 0f);
        //    }
        //}
    }
}
