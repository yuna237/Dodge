using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawer : MonoBehaviour
{
    public GameObject bulletprefab;
    //������ ź���� ���� ������
    public float spawnRateMin = 0.5f;
    //�ּ� ���� �ֱ�
    public float spawnRateMax = 3f;
    //�ִ� ���� �ֱ�

    public Transform target;
    //�߻��� ��� 
    public float spawnRate;
    //�����ֱ�
    public float timeAfterSpawn;
    //�ֱ� ���� �������� ���� �ð�

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
