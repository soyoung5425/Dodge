using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; //������ ź���� ���� ������
    public float spawnRateMin = 0.5f; //�ּ� ���� �ֱ�
    public float spawnRateMax = 3f; //�ִ� ���� �ֱ�

    private Transform target; //�߻��� ���
    private float spawnRate; //���� �ֱ�
    private float timeAfterSpawn; //�ֱ� ���� �������� ���� �ð�

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
