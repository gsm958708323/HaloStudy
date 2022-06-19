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
         * �����������ָ�򱻼�����
         * ����Ҫƽ�Ƶ���������ԭ��
         */
        var v1 = t1.position - t2.position;
        Debug.DrawLine(Vector3.zero, v1, Color.red);

        var v2 = t1.position + t2.position;
        Debug.DrawLine(Vector3.zero, v2, Color.blue);

        //1.��t3����v1�����ƶ�
        //tips��ʹ��normalized��ֻ��ȡ�����ķ��򣬱���ԭ�г���Ӱ������
        if (Input.GetKey(KeyCode.O))
        {
            //t3.position = t3.position + v1.normalized * Time.deltaTime * 5;
            t3.Translate(v1.normalized * Time.deltaTime *5);
        }

        //2.��v2���򳤶�Ϊ10������
        Debug.DrawLine(Vector3.zero, v2.normalized * 10, Color.green);
    }
}
