using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // Corrected the parameter name
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.UpdateScore(); // Corrected the reference to Score.instance
        }
    }
}
