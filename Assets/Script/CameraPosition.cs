using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;

    public static bool isFall = false;

    void FixedUpdate()
    {
        //transform.Translate(0, 0.2f, 0);
        if (_player.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, _player.transform.position.y, transform.position.z);
        }
        if (isFall)
        {
            transform.Translate(0,-0.3f,0);
        }
    }
}
