using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("pocetna");
    }

    // Update is called once per frame
    void Update()
    {
            SceneManager.LoadScene("scena2");
        
    }
}
