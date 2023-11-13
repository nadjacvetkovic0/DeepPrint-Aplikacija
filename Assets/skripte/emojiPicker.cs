using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class emojiPicker : MonoBehaviour
{
    // Start int is called before the first frame update
    int score;
    public Image slika1;
    public Image slika2;
    public Image slika3;
    void Start()
    {
        Debug.Log("radi nesto");
        Color color1 = slika1.color;
        color1.a = 0;
        Color color2 = slika2.color;
        color2.a = 0;
        Color color3 = slika3.color;
        color3.a = 0;

   
        if(score==100){
        color1.a = 100;  // Adjust this value for desired transparency
        slika1.color = color1;
        Debug.Log("radi nesto ooooooooo");

        }
        else if(score>=50){
        color2.a = 100;  // Adjust this value for desired transparency
        slika2.color = color1;
        }
        else{
        color3.a = 100;  // Adjust this value for desired transparency
        slika3.color = color1;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
