using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    [SerializeField] Text _timeText;
    [SerializeField] float _timeRimit;
    int _score;
    GameStatus _nowStatus;
    // Start is called before the first frame update
    void Start()
    {
        AddScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        switch (_nowStatus)
        {
            case GameStatus.init:
                _nowStatus = GameStatus.nowGame;
                break;
            case GameStatus.nowGame:
                DecleaceTime();
                if (_timeRimit <= 0)
                {
                    _nowStatus = GameStatus.gameEnd;
                }
                break;
            case GameStatus.gameEnd:
                break;
            default:
                break;
        }
    }

    public void DecleaceTime()
    {
        _timeRimit -= Time.deltaTime;
        _timeText.text = $"Time:{_timeRimit:0.00}";
    }

    public void AddScore(int score)
    {
        _score += score;
        _scoreText.text = $"Score:{_score}";
    }
}
public enum GameStatus
{ 
    init,
    nowGame,
    gameEnd
}