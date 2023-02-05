using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSence : MonoBehaviour
{
    // Start is called before the first frame update
    public void SenceLevel()
    {
        Application.LoadLevel("LevelScene");
    }

    public void SenceSelectLevel()
    {
        Application.LoadLevel("SelectLevel");
    }
}
