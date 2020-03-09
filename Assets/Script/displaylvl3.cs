using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displaylvl3 : MonoBehaviour
{

    void Update()
    {
        GetComponent<TextMesh>().text = clicklevel3.playerCode;
    }
}
