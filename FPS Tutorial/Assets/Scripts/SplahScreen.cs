using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplahScreen : MonoBehaviour
{
    public Image logo;
    Color logoColor;
    public float lerpMultiplier = 0.02f;

    void Start()
    {
        logoColor = new Color(1, 1, 1, 0);
        logo.color = logoColor;

        StartCoroutine(GotoMainMenu());
    }

    void Update()
    {
        logoColor = Color.Lerp(logoColor, new Color(1, 1, 1, 1), Time.time * lerpMultiplier);
        logo.color = logoColor;

    }

    IEnumerator GotoMainMenu()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("MainMenu");
    }
}
