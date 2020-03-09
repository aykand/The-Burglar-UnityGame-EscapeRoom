using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickLevelTwo : MonoBehaviour
{
    public static string correctCode = "PET";
    public static string playerCode = "";

    public static int totalDigits = 0;
    public static string didclick = "n";

    void Update()
    {
        Debug.Log(playerCode);
        if (totalDigits == 3)
        {
            if (playerCode == correctCode)
            {
                SceneManager.LoadScene("Level2End");
            }
            else
            {
                playerCode = "";
                totalDigits = 0;
                Debug.Log("lost");
            }
        }
    }
    void OnMouseUp()
    {
        playerCode += gameObject.name;
        totalDigits += 1;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 0);
        StartCoroutine(waittochange());
        didclick = "y";
    }
    void OnMouseOver()

    {
        if (didclick == "n")
            GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);

    }
    void OnMouseExit()
    {
        if (didclick == "n")
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
    }
    IEnumerator waittochange()
    {
        yield return new WaitForSeconds(1);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        didclick = "n";
    }
}
