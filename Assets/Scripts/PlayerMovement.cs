using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 1000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float steering = Input.GetAxis("Horizontal") * Time.deltaTime * sidewaysForce;
        //rb.AddForce(steering, 0, forwardForce * Time.deltaTime);
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        transform.Translate(steering, 0, 0);
        
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
