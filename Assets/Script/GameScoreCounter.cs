using UnityEngine;
using UnityEngine.UI;

public class GameScoreCounter : MonoBehaviour
{
    [SerializeField]
    private Transform _bugTransform;

    [SerializeField]
    private Text _gameScoreCounter;

    [SerializeField]
    private Text _gameOverText;

    [SerializeField]
    private GameObject _gameOverPanel;

    private int _gameScore;

    private void Awake()
    {
        GameEvents.gameOver.AddListener(GameOver);
    }
    void Update()
    {

        if (_bugTransform.position.y > _gameScore)
        {
            _gameScore = (int)_bugTransform.position.y;

            _gameScoreCounter.text = _gameScore.ToString();
        }

        else { return; }
    }
    void GameOver()
    {
        _gameOverText.text = "Game Over Score: " + _gameScore.ToString();

        _gameOverPanel.SetActive(true);

        Invoke("LoadMenu", 3);

        ScoreInstance.Instance.score = _gameScore;
    }
    void LoadMenu()
    {
        SceneController.Instance.SceneChanger(0);
    }
}
