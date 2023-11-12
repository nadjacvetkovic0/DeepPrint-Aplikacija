using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ChangeScene : MonoBehaviour
{
    public Button mybutton1;
    public TextMeshProUGUI button1text;
    public Button mybutton2;
    public TextMeshProUGUI button2text;
    public Button mybutton3;
    public TextMeshProUGUI button3text;
    int i = 0;
    public TextMeshProUGUI Pitanje1Text;
    [System.Serializable]
    public class JsonObject
    {
        public string pitanje;
        public List<Odgovor> odgovori;
    }

    [System.Serializable]
    public class Odgovor
    {
        public string odgovor;
        public int vrednost;
    }

    [System.Serializable]
    public class JsonWrapper
    {
        public List<JsonObject> jsonArray;
    }

    string jsonArrayString = "[{\"pitanje\":\"Nekopitanje1\",\"odgovori\":[{\"odgovor\":\"Nekiodgovor1\",\"vrednost\":5},{\"odgovor\":\"Nekiodgovor2\",\"vrednost\":10}]},{\"pitanje\":\"Nekopitanje2\",\"odgovori\":[{\"odgovor\":\"Nekiodgovor1\",\"vrednost\":10},{\"odgovor\":\"Nekiodgovor2\",\"vrednost\":5}]}]";

    JsonWrapper jsonWrapper;
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Specific scene loaded: " + scene.name);
        if (scene.name == "pitanje1") // Replace with your scene name
        {
            PromeniPitanje();
            mybutton1.onClick.AddListener(OnButtonClick);
            mybutton2.onClick.AddListener(OnButtonClick);
            mybutton3.onClick.AddListener(OnButtonClick);
        }
    }
    void PromeniPitanje()
    {

        // Deserialize JSON array into a JsonWrapper object
        jsonWrapper = JsonUtility.FromJson<JsonWrapper>("{\"jsonArray\":" + jsonArrayString + "}");

        // Access the list of JsonObjects from the JsonWrapper
        List<JsonObject> jsonArray = jsonWrapper.jsonArray;

        string pitanje = jsonArray[i].pitanje;
        Debug.Log(pitanje);
        Pitanje1Text.text = pitanje;

            //List<JsonObject> jsonOdgovori = jsonArray[i.odgovori];
            foreach (Odgovor odgovor in jsonArray[i].odgovori)
            {
                Debug.Log(odgovor.odgovor);
                Debug.Log(odgovor.vrednost);
                mybutton1text.text = odgovor.odgovor;

            }



    }
    void OnButtonClick()
    {
        Debug.Log("kliknut je button");
        i++;
        PromeniPitanje();
    }

}




