using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine.UI;

public class endpointGetter : MonoBehaviour
{
    public Text responseText;

    void Start()
    {
        StartCoroutine(Upload());
    }

    IEnumerator Upload()
    {
        using (UnityWebRequest www = new UnityWebRequest("https://ef17-188-2-107-65.ngrok-free.app/test", "POST"))
        {
            byte[] bodyRaw = Encoding.UTF8.GetBytes("{\"title\":\"foo\",\"body\":\"bar\",\"userId\":1}");
            www.uploadHandler = new UploadHandlerRaw(bodyRaw);
            www.downloadHandler = new DownloadHandlerBuffer();
            www.SetRequestHeader("Content-Type", "application/json");

            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Error: " + www.error);
            }
            else
            {
                string response = www.downloadHandler.text;
                Debug.Log("POST Response: " + response);
                DisplayResponse(response);
            }
        }
    }

    void DisplayResponse(string response)
    {
        if (responseText != null)
        {
            responseText.text = response;
        }
        else
        {
            Debug.LogWarning("Response Text component not assigned!");
        }
    }
}
