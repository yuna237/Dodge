using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRigidbody;//�̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;//�̵� �ӷ�
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã��
        //PlayerRigidbody(����)�� �Ҵ�
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� �ÿ��� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vector3 �ӵ��� (xSpeed, 0, zSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //������ٵ��� �ӵ��� newVelocity �Ҵ�
        PlayerRigidbody.velocity = newVelocity;
    }
    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}
