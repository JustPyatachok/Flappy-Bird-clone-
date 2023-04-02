using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _pipes;

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
        while (!GameOverLogic.GameOver)
        {
            Instantiate(_pipes, new Vector2(transform.position.x, Random.Range(-_spawnRangeY, _spawnRangeY)), transform.rotation);
            yield return new WaitForSeconds(2);
        }
        
    }
}
