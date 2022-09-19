using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;//ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody;//�̵��� ����� ������ٵ� ������Ʈ

    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;
    }


}
