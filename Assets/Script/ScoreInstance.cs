using UnityEngine;

public class ScoreInstance : MonoBehaviour
{
    public static ScoreInstance Instance;

    public int score = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { Destroy(this); }
    }
}
