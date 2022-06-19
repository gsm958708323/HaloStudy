using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 三角函数
/// </summary>
public class Trigonometric : MonoBehaviour
{
    public Transform t1, t2, t3;
    // Start is called before the first frame update
    void Start()
    {
    }

    /// <summary>
    /// 计算物体右前方30度，10m远的坐标
    /// </summary>
    private void demo2()
    {
        // sin30 = x / 10
        // tan30 = x / z
        float x = Mathf.Sin(30 * Mathf.Deg2Rad) * 10;
        float z = x / Mathf.Tan(30 * Mathf.Deg2Rad);
        // 将自身坐标转换为世界坐标。因为DrawLine是基于世界左边划线的
        Vector3 v = transform.TransformPoint(x, transform.position.y, z);
        Debug.DrawLine(transform.position, v, Color.green);

        //Debug.DrawLine(Vector3.zero, new Vector3(x, transform.position.y, z), Color.green);
        //Debug.DrawLine(Vector3.zero, v, Color.green);
    }

    void demo1()
    {
        // 角度转弧度 弧度=角度*PI/180
        int angle = 30;
        float rad11 = angle * Mathf.Deg2Rad;
        float rad12 = angle * Mathf.PI / 180;
        print($"角度：{angle}, 弧度：{rad11} {rad12}");

        // 弧度转角度 角度=弧度*180/PI
        double rad2 = 0.5235988;
        double deg = rad2 * Mathf.Rad2Deg;
        double deg2 = rad2 * 180 / Mathf.PI;
        print($"弧度：{rad2}, 角度：{deg} {deg2}");
    }

    // Update is called once per frame
    void Update()
    {
        demo4();
    }

    /// <summary>
    /// 判断player有没有进入boss攻击范围
    /// </summary>
    private void demo4()
    {
        //计算距离
        float dis = Vector3.Distance(transform.position, t2.position);
        if (dis <= 10)
        {
            //计算夹角
            // a*b = cos X
            float dot = Vector3.Dot(transform.forward, (t2.position - transform.position).normalized);
            float angle = Mathf.Acos(dot) * Mathf.Rad2Deg;
            print(angle);
            if (angle <= 60)
            {
                print("进入攻击范围");
            }
        }
    }

    /// <summary>
    /// 求t1和t2的夹角
    /// </summary>
    private void demo3()
    {
        //tips: 只有当t1 t2为单位向量时，公式可简化。a*b = cos<a,b>
        float dot = Vector3.Dot(t1.position.normalized, this.t3.position.normalized);
        // 1.用点乘计算1-180夹角
        float angle = Mathf.Acos(dot) * Mathf.Rad2Deg;
        Debug.DrawLine(Vector3.zero, t1.position, Color.blue);
        Debug.DrawLine(Vector3.zero, this.t3.position, Color.yellow);

        // 2.用叉乘判断360度夹角
        Vector3 crossV = Vector3.Cross(t1.position, t3.position);
        if (crossV.y < 0)
        {
            angle = 360 - angle;
        }
        print(angle);
        Debug.DrawLine(Vector3.zero, crossV, Color.red);
    }
}
