using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthSystem : MonoBehaviour
{
    public Text LifeCount;
    public int defaultHealthCount;
    public int healthCount;

    //health count 
    public void Init()
    {
        healthCount = defaultHealthCount;
        LifeCount.text = healthCount.ToString();
    }

    //lose health
    public void LoseHealth()
    {
        if (healthCount < 1)
            return;

        healthCount--;
        LifeCount.text = healthCount.ToString();

        CheckHealthCount();
    }

    //check health count for losing

    void CheckHealthCount()
    {
        if(healthCount<1)
        {
            Debug.Log("You lost");
            
        }
 
    }
}
