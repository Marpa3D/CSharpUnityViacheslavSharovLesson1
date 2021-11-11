using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // ���������� ���������� ���������. ������ ������ ���������� "Marpa3D" �������

    [Header("�������� ����������� ���������")]
    [SerializeField] private float _speed = 7f;
    void Update()
    {
        Movement();
    }
    
    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * Time.deltaTime * _speed;
        }
    }
}
