using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameArrangemet : MonoBehaviour 
{
    public GameObject[] cubes;
    public GameObject buttons, m_cube, cubes_anim;
    public Light dirLight, dirLight_2;
    public Text playTxt, gameName;

    public bool clicked;

    void Update()
    {
        if (clicked && dirLight.intensity != 0)
            dirLight.intensity -= 0.3f;
        if (clicked && dirLight_2.intensity >= 1.05f)
            dirLight_2.intensity -= 0.25f;
    }

    void OnMouseDown()
    {
        if (!clicked)
        {
            StartCoroutine(delCubes());
            playTxt.gameObject.SetActive(false);
            gameName.text = "0";

            buttons.GetComponent<ScrollObject>().speed = -5f;
            buttons.GetComponent<ScrollObject>().checkPost = -150f;
            m_cube.GetComponent<Animation>().Play("StartGameCube");
            // m_cube.transform.localScale = new Vector3(1f, 1f, 1f); Размер куба
            cubes_anim.GetComponent<Animation>().Play();
        }
    }

    IEnumerator delCubes() 
    {
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(0.5f);
            Destroy(cubes[i]);
        }
    }
}