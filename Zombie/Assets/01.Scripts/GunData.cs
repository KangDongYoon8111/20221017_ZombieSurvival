using UnityEngine;

public class GunData
{
    public AudioClip shotClip; // �߻� �Ҹ�
    public AudioClip reloadClip; // ������ �Ҹ�

    public float damage = 25; // ���ݷ�

    // ó���� �־��� ��ü ź��
    public int startAmmoRemain = 100;
    public int magCapacity = 25; // źâ �뷮

    public float timeBetFire = 0.12f; // ź�� �߻� ����
    public float reloadTime = 1.8f; // ������ �ҿ� �ð�
}
