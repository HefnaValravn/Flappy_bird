using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{

    public static score instance;

    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    private int _score;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Update()
    {
        currentScoreText.text = _score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }


    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            highScoreText.text = _score.ToString();
        }
    }


    public void UpdateScore()
    {
        _score++;
        currentScoreText.text = _score.ToString();
        UpdateHighScore();
    } 
}
