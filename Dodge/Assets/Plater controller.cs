using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platercontroller : MonoBehaviour
{
    public Rigidbody PlayerRigidbody;//�̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;//�̵� �ӷ�
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //���� ����Ű �Է��� ������ ��� z ���� ���ֱ�
            PlayerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            // �Ʒ��� ����Ű �Է��� ������ ��� -z ���� ���ֱ�
            PlayerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            //������ ����Ű �Է��� ������ ��� x ���Ⱘ �ֱ�
            PlayerRigidbody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //���� ����Ű �Է��� ������ ��� -x ���� �� �ֱ�
            PlayerRigidbody.AddForce(-speed, 0f, 0f);
        }
           
    }
     
        

}
