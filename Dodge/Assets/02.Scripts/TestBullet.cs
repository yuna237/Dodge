using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBullet : MonoBehaviour
{
    //�̵��� ����� ������ٵ� ������Ʈ
    private Rigidbody bulletRigidbody;
    //ź�� �̵� �ӷ�
    public float speed = 8f;

    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        //3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);
    }

    //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        //�浹�� ���� ���� ������Ʈ�� Plater �±׸� ���� ���
        if (other.tag == "Player")
        {
            //���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            TestPlayerController playerController = other.GetComponent<TestPlayerController>();

            //�������κ��� PlayerController ������Ʈ �������� �� ���� �ߴٸ�
            if (playerController != null)
            {
                //���� PlayerController ������Ʈ Die() �޼��� ����
                playerController.Die();
            }
        }
    }


}
