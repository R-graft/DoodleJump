using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlatform : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 380f);

            GetComponent<Animator>().enabled = true;

            AudioManager.AudioInstance.PlaySound("jump");

            Invoke("Disabled", 2);
        }
    }
    void Disabled()
    {
       gameObject.SetActive(false);
    }
}
