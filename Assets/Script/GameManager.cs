using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    [SerializeField] float _timeRimit;
    [SerializeField] int _maxOder;
    GameStatus _nowStatus;
    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
public enum GameStatus
{ 
    init,
    nowGame,
    gameEnd
}