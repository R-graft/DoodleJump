using UnityEngine;

public class PauseButton : MonoBehaviour
{
    private bool _on = false;
    public void OnPausePush()
    {
        if (!_on)
        {
            Time.timeScale = 0f;
            _on = true;
        }
        else 
        { 
            Time.timeScale = 1f;
            _on = false;
        }
    }
}
