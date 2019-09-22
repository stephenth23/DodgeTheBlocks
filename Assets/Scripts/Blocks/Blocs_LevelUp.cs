using UnityEngine;
using System.Collections;

public class Blocs_LevelUp : MonoBehaviour
{
    public void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }
}