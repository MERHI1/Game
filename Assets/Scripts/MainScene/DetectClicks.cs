using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DetectClicks : MonoBehaviour
{
    public GameObject buttons;
    public Text playTxt, gameName;

    public bool clicked; 

    void OnMouseDown()
    {
        if (!clicked)
        {
            playTxt.gameObject.SetActive(false);
            gameName.text = "0";

            buttons.GetComponent<ScrollObject>().speed = -5f;
            buttons.GetComponent<ScrollObject>().checkPost = -150f;
        }
    }
}
