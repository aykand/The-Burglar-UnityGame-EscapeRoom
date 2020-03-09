using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displaylvl4 : MonoBehaviour
{

    void Update()
    {
        GetComponent<TextMesh>().text = clicklevel4.playerCode;
    }
}
