using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTeleport : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = new Vector2(gameObject.transform.position.x + 6, gameObject.transform.position.y );
    }
}
