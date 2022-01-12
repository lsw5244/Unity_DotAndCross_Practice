using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLookAt2 : MonoBehaviour
{
    public Transform target;
    public float viewingAngle = 70.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 foward = transform.forward;
        Vector3 toOther = target.position - transform.position;

        float dot = Vector3.Dot(foward, toOther); // 삼각형 만들기
        float angle = Mathf.Acos(dot / toOther.magnitude); // 각도 얻기

        Vector3 normalVec = Vector3.Cross(toOther, transform.forward);

        if(angle * Mathf.Rad2Deg < viewingAngle)
        {
            if (Vector3.Dot(Vector3.up, normalVec) < 0f)
            {
                // 타겟이 오른쪽에 있음
                transform.rotation *= Quaternion.Euler(0f, angle, 0f);
            }
            else
            {
                // 타겟이 왼쪽에 있음
                transform.rotation *= Quaternion.Euler(0f, -angle, 0f);
            }
        }

    }
}
