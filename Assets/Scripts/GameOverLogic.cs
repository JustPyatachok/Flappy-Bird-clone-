using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLogic : MonoBehaviour
{
    private Rigidbody2D _playerRb;
    [SerializeField]private GameObject _GameOverUi;
    public static bool IsGameOver;
    void Start()
    {
        _GameOverUi.SetActive(false);
        _playerRb = GetComponent<Rigidbody2D>();
        IsGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerRb.transform.position.y < -6 || _playerRb.transform.position.y > 8)
        {
            GameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }
    private void GameOver()
    {
        Debug.Log("game over");
        _playerRb.bodyType = RigidbodyType2D.Static;
        IsGameOver = true;
        _GameOverUi.SetActive(true);
    }
}
