using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���Ǻ���
/// </summary>
public class Trigonometric : MonoBehaviour
{
    public Transform t1, t2, t3;
    // Start is called before the first frame update
    void Start()
    {
    }

    /// <summary>
    /// ����������ǰ��30�ȣ�10mԶ������
    /// </summary>
    private void demo2()
    {
        // sin30 = x / 10
        // tan30 = x / z
        float x = Mathf.Sin(30 * Mathf.Deg2Rad) * 10;
        float z = x / Mathf.Tan(30 * Mathf.Deg2Rad);
        // ����������ת��Ϊ�������ꡣ��ΪDrawLine�ǻ���������߻��ߵ�
        Vector3 v = transform.TransformPoint(x, transform.position.y, z);
        Debug.DrawLine(transform.position, v, Color.green);

        //Debug.DrawLine(Vector3.zero, new Vector3(x, transform.position.y, z), Color.green);
        //Debug.DrawLine(Vector3.zero, v, Color.green);
    }

    void demo1()
    {
        // �Ƕ�ת���� ����=�Ƕ�*PI/180
        int angle = 30;
        float rad11 = angle * Mathf.Deg2Rad;
        float rad12 = angle * Mathf.PI / 180;
        print($"�Ƕȣ�{angle}, ���ȣ�{rad11} {rad12}");

        // ����ת�Ƕ� �Ƕ�=����*180/PI
        double rad2 = 0.5235988;
        double deg = rad2 * Mathf.Rad2Deg;
        double deg2 = rad2 * 180 / Mathf.PI;
        print($"���ȣ�{rad2}, �Ƕȣ�{deg} {deg2}");
    }

    // Update is called once per frame
    void Update()
    {
        demo4();
    }

    /// <summary>
    /// �ж�player��û�н���boss������Χ
    /// </summary>
    private void demo4()
    {
        //�������
        float dis = Vector3.Distance(transform.position, t2.position);
        if (dis <= 10)
        {
            //����н�
            // a*b = cos X
            float dot = Vector3.Dot(transform.forward, (t2.position - transform.position).normalized);
            float angle = Mathf.Acos(dot) * Mathf.Rad2Deg;
            print(angle);
            if (angle <= 60)
            {
                print("���빥����Χ");
            }
        }
    }

    /// <summary>
    /// ��t1��t2�ļн�
    /// </summary>
    private void demo3()
    {
        //tips: ֻ�е�t1 t2Ϊ��λ����ʱ����ʽ�ɼ򻯡�a*b = cos<a,b>
        float dot = Vector3.Dot(t1.position.normalized, this.t3.position.normalized);
        // 1.�õ�˼���1-180�н�
        float angle = Mathf.Acos(dot) * Mathf.Rad2Deg;
        Debug.DrawLine(Vector3.zero, t1.position, Color.blue);
        Debug.DrawLine(Vector3.zero, this.t3.position, Color.yellow);

        // 2.�ò���ж�360�ȼн�
        Vector3 crossV = Vector3.Cross(t1.position, t3.position);
        if (crossV.y < 0)
        {
            angle = 360 - angle;
        }
        print(angle);
        Debug.DrawLine(Vector3.zero, crossV, Color.red);
    }
}
