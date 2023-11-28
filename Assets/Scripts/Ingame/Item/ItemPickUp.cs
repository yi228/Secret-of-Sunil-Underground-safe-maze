using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Items item;
    public float amplitude = 0.1f;    // ��� ����
    public float frequency = 3f;    // ��� ���ļ�

    private Vector3 initialPosition;

    void Start()
    {
        // �ʱ� ��ġ ����
        initialPosition = transform.position;
    }

    void Update()
    {
        // �ð��� ���� ���ο� Y ��ġ ���
        float newY = initialPosition.y + amplitude * Mathf.Sin(Time.time * frequency);

        // ���� ��ġ�� ���� ���� ��ġ�� ���� (X, Z ���� �״�� ����)
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
