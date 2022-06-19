using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorDef : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        //Demo1();
        Demo2();
    }

    void Demo2()
    {
        //��ǰ�����ĵ�λ����
        var pos = target.position;
        var v1 = pos.normalized;
        Debug.DrawLine(Vector3.zero, pos);
        Debug.DrawLine(Vector3.zero, v1, Color.blue);
    }

    void Demo1()
    {
        /*
         * �������д�С�ͷ���������߶�
         * ��С��������ģ��
         * ���������˿ռ���������ָ��
         */
        Debug.DrawLine(Vector3.zero, target.position);

        var pos = target.position;

        //��������ģ��
        var v1 = target.position.magnitude;
        var v2 = Vector3.Distance(Vector3.zero, target.position);
        var v3 = Mathf.Sqrt(Mathf.Pow(pos.x, 2) + Mathf.Pow(pos.y, 2) + Mathf.Pow(pos.z, 2));
        print($"{v1} {v2} {v3}");
    }
}
