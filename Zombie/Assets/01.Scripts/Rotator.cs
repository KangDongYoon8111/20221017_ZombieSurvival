using UnityEngine;

public class Rotator : MonoBehaviour
{
    // �ʴ� ȸ�� �ӵ�
    public float rotationSpeed = 60f;

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
