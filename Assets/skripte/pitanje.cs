using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pitanje : MonoBehaviour
{

    public Text Pitanje1Text;
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

    public void Start()
    {
        // Deserialize JSON array into a JsonWrapper object
        jsonWrapper = JsonUtility.FromJson<JsonWrapper>("{\"jsonArray\":" + jsonArrayString + "}");

        // Access the list of JsonObjects from the JsonWrapper
        List<JsonObject> jsonArray = jsonWrapper.jsonArray;

        string pitanje = jsonArray[0].pitanje;
        Debug.Log(pitanje);
        Pitanje1Text.text= pitanje;

        // Iterate through the list
        /*foreach (JsonObject jsonData in jsonArray)
        {
            Debug.Log("Pitanje: " + jsonData.pitanje);
            foreach (Odgovor odgovor in jsonData.odgovori)
            {
                Debug.Log("Odgovor: " + odgovor.odgovor + ", Vrednost: " + odgovor.vrednost);
            }
        }*/


    }
}