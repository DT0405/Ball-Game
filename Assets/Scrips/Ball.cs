using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public string color;

    public void Reset () {
        transform.position = new Vector3(Random.Range(-7f, 7f), 1, Random.Range(-7f, 7f));
    }
}
