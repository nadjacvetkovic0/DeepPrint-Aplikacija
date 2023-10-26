using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Restart()
    {
        SceneManager.LoadScene("pocetna");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene("scena2");
        }

    }
}
