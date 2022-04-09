using UnityEngine;

public class GrayPlatform : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                transform.GetChild(0).gameObject.SetActive(true);

                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<BoxCollider2D>().isTrigger = true;
                GetComponent<Rigidbody2D>().gravityScale = 0.5f;

                AudioManager.AudioInstance.PlaySound("crash");
            }
        }
        else { return; }
    }
}
