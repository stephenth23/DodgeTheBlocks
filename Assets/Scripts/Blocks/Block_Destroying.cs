using UnityEngine;
using System.Collections;

public class Block_Destroying : MonoBehaviour
{
    public void Update()
    {
        if (transform.position.y <= -7f)
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager_Score>().UpdatingScore();
        }
    }
}