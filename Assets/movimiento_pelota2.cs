using UnityEngine;

public class movimiento_pelota2 : MonoBehaviour
{
    public float fuerza = 25f;          
    [SerializeField] private Rigidbody rb;
    bool inicio = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) && inicio == false)
        {
            inicio = true;
            rb.AddForce(transform.forward * fuerza, ForceMode.Impulse);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Vector3 pos = transform.position;
        Vector3 to = pos + rb.velocity;
        Gizmos.DrawLine(pos, to);

    }

    
}
