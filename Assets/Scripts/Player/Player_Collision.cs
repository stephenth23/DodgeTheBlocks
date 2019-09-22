using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player_Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Block")
            FindObjectOfType<GameManager>().EndGame();
    }
}
