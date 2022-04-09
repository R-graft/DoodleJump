using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 700f);

            AudioManager.AudioInstance.PlaySound("spring");
        }
    }
}
