using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float rotationSpeed = 30f;
    [SerializeField]
    float turboSpeed = 50f;
    [SerializeField]
    float normalSpeed = 30f;
    SurfaceEffector2D surfaceEffector;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        Turbo();
    }

    void Turbo()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = turboSpeed;
        }
        else
        {
            surfaceEffector.speed = normalSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-rotationSpeed);
        }
    }
}
