using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Hit! Tag = " + other.tag);
        if(other.CompareTag("Paint"))
        {
            Destroy(gameObject);
        }
    }
}
