using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Hall")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            CameraPosition.isFall = true;

            AudioManager.AudioInstance.PlaySound("fall");

            GameEvents.gameOver.Invoke();
        }

        else
        {
            PlatformPooler.instance.GetPlatform();

            collision.gameObject.SetActive(false);
        } 
    }
   
}
