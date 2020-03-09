using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassLvl1 : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadScene("Level2");

    }

}
