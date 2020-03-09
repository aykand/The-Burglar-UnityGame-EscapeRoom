using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displaylvl2 : MonoBehaviour
{
    
    void Update()
    {
        GetComponent<TextMesh>().text = clickLevelTwo.playerCode;
    }
}
