using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectingPoint : MonoBehaviour
{
    public TextMeshProUGUI Point;
    private int _pointCounter = 0;
    private void Update()
    {
        Point.text = $"{_pointCounter}";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _pointCounter++;
    }
}
