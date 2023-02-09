using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour
{
    [SerializeField] private int money; // curret amount
    private int waitTime = 5;           // seconds between money-gain
    private int moneyGain = 10;         // amount pr. money-gain
    public Text moneytext;    

    private void Awake()
    {
        money = 20;
        TextControl();
    }

    // Start is called before the first frame update
    void Start()
    {           
        StartCoroutine(MoneyTimer());
    }

    private void TextControl()
    {
        moneytext.text = money + " g";
    }

    private IEnumerator MoneyTimer()
    {
        
        while (true) {
            
            yield return new WaitForSeconds(waitTime);
            money = money + moneyGain;
            
            TextControl();            
        }
    }
}
