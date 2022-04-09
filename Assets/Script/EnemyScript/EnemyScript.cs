using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private string _sound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);

            AudioManager.AudioInstance.PlaySound(_sound);

            GameEvents.gameOver.Invoke();
        }
        else { transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f); }
    }
}
