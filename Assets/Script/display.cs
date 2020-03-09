using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = click.playerCode; 
    }
}
