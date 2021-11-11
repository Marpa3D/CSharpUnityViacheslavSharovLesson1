using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // ”правление движени€ми персонажа. —крипт создан ¬€чеславом "Marpa3D" Ўаровым

    [Header("—корость перемещение персонажа")]
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
