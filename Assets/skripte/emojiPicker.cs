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
    public Image slika1;//najbolje
    public Image slika2;
    public Image slika3;
    public Image slika4;
    public Image slika5;
    public Image slika6;//najgore
    void Start()
    {
        Debug.Log("radi nesto");
        Color color1 = slika1.color;
        color1.a = 0;
        Color color2 = slika2.color;
        color2.a = 0;
        Color color3 = slika3.color;
        color3.a = 0;
        Color color4 = slika4.color;
        color4.a = 0;
        Color color5 = slika5.color;
        color5.a = 0;
        Color color6 = slika6.color;
        color6.a = 0;

   
        if(score==100){
        color1.a = 100;  // Adjust this value for desired transparency
        slika1.color = color1;
        Debug.Log("STO POENA");
        }
        else if(score>=90){
        color2.a = 100;  // Adjust this value for desired transparency
        slika2.color = color2;
        Debug.Log("ISPODDDDDD STO POENA");
        }
        else if(score>=80){ 
        color3.a = 100;  // Adjust this value for desired transparency
        slika3.color = color3;
        }
        else if(score>=70){ 
        color4.a = 100;  // Adjust this value for desired transparency
        slika4.color = color4;
        }
        else if(score>=60){ 
        color5.a = 100;  // Adjust this value for desired transparency
        slika5.color = color5;
        }
        else{
        color6.a = 100;  // Adjust this value for desired transparency
        slika6.color = color6;       
        }

   
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}