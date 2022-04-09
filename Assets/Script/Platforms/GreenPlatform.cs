using UnityEngine;
public class GreenPlatform : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 380f);

            AudioManager.AudioInstance.PlaySound("jump");
        }
    }
}
