using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _pipes;
    [SerializeField] private float _spawnRangeOnSecond = 1.8f;
    private float _spawnRangeY = 3;

    void Start()
    { 
        StartCoroutine("CreatePipe");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CreatePipe()
    {
        Debug.Log($"Start coroutine - {GameOverLogic.IsGameOver}");
        while (!GameOverLogic.IsGameOver)
        {
            Instantiate(_pipes, new Vector2(transform.position.x, Random.Range(-_spawnRangeY, _spawnRangeY)), transform.rotation);
            yield return new WaitForSeconds(_spawnRangeOnSecond);
        }
        
    }
}
