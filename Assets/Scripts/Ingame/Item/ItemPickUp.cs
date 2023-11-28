using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Items item;
    public float amplitude = 0.1f;    // 운동의 진폭
    public float frequency = 3f;    // 운동의 주파수

    private Vector3 initialPosition;

    void Start()
    {
        // 초기 위치 저장
        initialPosition = transform.position;
    }

    void Update()
    {
        // 시간에 따른 새로운 Y 위치 계산
        float newY = initialPosition.y + amplitude * Mathf.Sin(Time.time * frequency);

        // 현재 위치를 새로 계산된 위치로 설정 (X, Z 축은 그대로 유지)
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
