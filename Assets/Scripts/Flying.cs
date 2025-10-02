using UnityEngine;

public class Flying : MonoBehaviour
{
    public float jumpStrength;
    public float rotationSpeed;
    private Rigidbody2D _rb;
    private bool isPressing = false;
    private bool wasPressing = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.linearVelocityX = 0;
        wasPressing = isPressing;
        if (Input.GetKey(KeyCode.Space) && !isPressing)
        {
            _rb.linearVelocity = new Vector2(0, 0);
            _rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
            isPressing = true;
        }

        if (Input.GetKeyUp(KeyCode.Space) && wasPressing)
        {
            isPressing = false;
        }
    }


    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.linearVelocity.y * rotationSpeed);
    }
}
