using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;

public class RiotManager : MonoBehaviour
{
    private readonly string RiotDevKey = "RGAPI-fdd160f9-6d2f-46f6-a468-523b229ce1f2";

    public static RiotManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        Instance = this;
        AddUser("test", "test");
    }

    public void AddUser(string UserName, string TagLine) => StartCoroutine(ValidateRiotAPI(UserName, TagLine));
    private IEnumerator ValidateRiotAPI(string UserName, string TagLine)
    {
        var uri = $"https://europe.api.riotgames.com/riot/account/v1/accounts/by-riot-id/{UserName}/{TagLine}?api_key={RiotDevKey}";
        using (var webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            Debug.Log(webRequest.result);

            if (webRequest.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Validation failed");
                yield break;
            }

            var response = webRequest.downloadHandler.text;
            Debug.Log(response);
            var puuid = JObject.Parse(response).GetValue("puuid").ToString();
            FirebaseManager.Instance.AddUser(UserName, TagLine, puuid);
        }
    }
}
