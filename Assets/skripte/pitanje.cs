using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitanje : MonoBehaviour
{
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

    string jsonArrayString = "[{\"pitanje\":\"Nekopitanje1\",\"odgovori\":[{\"odgovor\":\"Nekiodgovor1\",\"vrednost\":5},{\"odgovor\":\"Nekiodgovor2\",\"vrednost\":10}]},{\"pitanje\":\"Nekopitanje2\",\"odgovori\":[{\"odgovor\":\"Nekiodgovor1\",\"vrednost\":10},{\"odgovor\":\"Nekiodgovor2\",\"vrednost\":5}]}]";

    List<JsonObject> jsonArray;

    void Start()
    {
        // Deserialize JSON array into a list of JsonObject
        jsonArray = JsonUtility.FromJson<List<JsonObject>>(jsonArrayString);

        // Iterate through the list
        foreach (JsonObject jsonData in jsonArray)
        {
            Debug.Log("Pitanje: " + jsonData.pitanje);
            foreach (Odgovor odgovor in jsonData.odgovori)
            {
                Debug.Log("Odgovor: " + odgovor.odgovor + ", Vrednost: " + odgovor.vrednost);
            }
        }
    }
}
