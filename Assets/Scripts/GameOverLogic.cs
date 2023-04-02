using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLogic : MonoBehaviour
{
    private Rigidbody2D _playerRb;
    public static bool GameOver = false; 
    void Start()
    {
         _playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("game over");
        _playerRb.bodyType = RigidbodyType2D.Static;
        GameOver = true;
    }
}
