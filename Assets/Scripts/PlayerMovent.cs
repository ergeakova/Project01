using UnityEngine;

public class PlayerMovent : MonoBehaviour
{
    public Rigidbody rb;
    public float fowardForce = 1000f;
    public float sidewayForce = 500f;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
     //   rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
