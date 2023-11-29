using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class emojiPicker : MonoBehaviour
{
    int finalScore;
    int score;
    public Image slika1; //najbolje
    public Image slika2;
    public Image slika3;
    public Image slika4;
    public Image slika5;
    public Image slika6; //najgore

    void Start()
    {
        score = PlayerPrefs.GetInt("score");
        finalScore = 100 - score;
        Debug.Log("Score: " + finalScore);

        SetImageAlpha(slika1, finalScore == 100 ? 1.0f : 0);
        SetImageAlpha(slika2, (finalScore >= 90 && finalScore<100) ? 1.0f : 0);
        SetImageAlpha(slika3, (finalScore >= 80 && finalScore<90)  ? 1.0f : 0);
        SetImageAlpha(slika4, (finalScore >= 70 && finalScore<80) ? 1.0f : 0);
        SetImageAlpha(slika5, (finalScore >= 60 && finalScore<70) ? 1.0f : 0);
        SetImageAlpha(slika6, finalScore < 60 ? 1.0f : 0);
    }

    void SetImageAlpha(Image image, float alpha)
    {
        Color color = image.color;
        color.a = alpha;
        image.color = color;
    }

    void Update()
    {
        // Your update logic here
    }
}
