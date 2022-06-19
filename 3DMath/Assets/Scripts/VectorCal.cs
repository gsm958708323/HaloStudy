using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorCal : MonoBehaviour
{
    public Transform t1, t2, t3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * 两向量相减，指向被减向量
         * 向量要平移到世界坐标原点
         */
        var v1 = t1.position - t2.position;
        Debug.DrawLine(Vector3.zero, v1, Color.red);

        var v2 = t1.position + t2.position;
        Debug.DrawLine(Vector3.zero, v2, Color.blue);

        //1.让t3朝着v1方向移动
        //tips：使用normalized，只获取向量的方向，避免原有长度影响速率
        if (Input.GetKey(KeyCode.O))
        {
            //t3.position = t3.position + v1.normalized * Time.deltaTime * 5;
            t3.Translate(v1.normalized * Time.deltaTime *5);
        }

        //2.求v2方向长度为10的向量
        Debug.DrawLine(Vector3.zero, v2.normalized * 10, Color.green);
    }
}
