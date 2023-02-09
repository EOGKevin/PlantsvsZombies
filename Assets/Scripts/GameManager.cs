
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake() { instance = this; }


    //health system
    void Start()
    {
        GetComponent<HealthSystem>().Init();
    }


}
