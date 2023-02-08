using Firebase;
using Firebase.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirebaseManager : MonoBehaviour
{

    public DependencyStatus dependencyStatus;
    private FirebaseFirestore db;
    public static FirebaseManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                //If they are avalible Initialize Firebase
                InitializeFirebase();
            }
            else
            {
                Debug.LogError("Could not resolve all Firebase dependecies: " + dependencyStatus);
            }
        });
    }

    private void InitializeFirebase()
    {
        db = FirebaseFirestore.DefaultInstance;
    }

    public void AddUser(string userName, string tagLine, string puuid)
    {
        var docRef = db.Collection("Users").Document(puuid);
        Dictionary<string, object> user = new()
        {
            {"User Name", userName},
            {"Tag Line", tagLine},
        };
        docRef.SetAsync(user);
    }
}
