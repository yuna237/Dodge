using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawer : MonoBehaviour
{
    public GameObject bulletprefab;
    //생성할 탄알의 원본 프라팹
    public float spawnRateMin = 0.5f;
    //최소 생성 주기
    public float spawnRateMax = 3f;
    //최대 생성 주기

    public Transform target;
    //발사할 대상 
    public float spawnRate;
    //생성주기
    public float timeAfterSpawn;
    //최근 생성 시점에서 지난 시간

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
