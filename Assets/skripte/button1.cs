using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Restart()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("dugme1"))
        {
            SceneManager.LoadScene("scena2");
        }

    }
}
