using UnityEngine;

public class BluePlatform : MonoBehaviour
{
    private bool toleft = true;

    private float _leftPoint = -2.6f;

    private float _rightPoint = 2.3f;

    void FixedUpdate()
    { 
        if (transform.position.x > _leftPoint && toleft)
        {
            transform.Translate(Vector3.left * Time.fixedDeltaTime);
            toleft = true;
        }
        else { toleft = false;}
        
        if (transform.position.x < _rightPoint && !toleft)
        {
            toleft = false;
            transform.Translate(Vector3.right * Time.fixedDeltaTime);
        }
        else { toleft = true; } 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 380f);

            AudioManager.AudioInstance.PlaySound("jump");
        }
    }
}
