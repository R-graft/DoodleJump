using UnityEngine;
using UnityEngine.UI;

public class BestScores : MonoBehaviour
{
    [SerializeField]
    private Text[] _bestScores;

    private  int _bestScore;

    private void Start()
    {
        _bestScore = ScoreInstance.Instance.score;

        for (int i = 0; i < _bestScores.Length; i++)
        {
            PlayerPrefs.GetInt(i.ToString(), 0);

            _bestScores[i].text = PlayerPrefs.GetInt(i.ToString()).ToString();  
        }

        AddBestScore();
    }
    void AddBestScore()
    {
        if(_bestScore > PlayerPrefs.GetInt("0"))
        {
            PlayerPrefs.SetInt("2",PlayerPrefs.GetInt("1"));
            PlayerPrefs.SetInt("1", PlayerPrefs.GetInt("0"));
            PlayerPrefs.SetInt("0", _bestScore);
        }
        else { return; }
    }
}
