using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    private Rigidbody2D _pipeRb;

    [SerializeField] private float _speed = 6f;

    void Start()
    {
        _pipeRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (GameOverLogic.IsGameOver)
        {
            _speed = 0f;
        }
        _pipeRb.velocity = Vector2.left * _speed;

        if (transform.position.x < -12)
        {
            DestroyPipe();
        }
    }
    private void DestroyPipe()
    {
        Destroy(gameObject);
    }
}
