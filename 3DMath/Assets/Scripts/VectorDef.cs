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
        //求当前向量的单位向量
        var pos = target.position;
        var v1 = pos.normalized;
        Debug.DrawLine(Vector3.zero, pos);
        Debug.DrawLine(Vector3.zero, v1, Color.blue);
    }

    void Demo1()
    {
        /*
         * 向量：有大小和方向的有向线段
         * 大小：向量的模长
         * 方向：描述了空间中向量的指向
         */
        Debug.DrawLine(Vector3.zero, target.position);

        var pos = target.position;

        //求向量的模长
        var v1 = target.position.magnitude;
        var v2 = Vector3.Distance(Vector3.zero, target.position);
        var v3 = Mathf.Sqrt(Mathf.Pow(pos.x, 2) + Mathf.Pow(pos.y, 2) + Mathf.Pow(pos.z, 2));
        print($"{v1} {v2} {v3}");
    }
}
