using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class monstermaster : MonoBehaviour
{ 
    protected string MName { get; set; }
    protected int MHp { get; set; }
    protected int MDmg { get; set; }
    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;
    public GameObject tower4;
    public GameObject tower5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MHp == 0)
        {
            Destroy(gameObject);
        }
    }
    public void Dead()
    {
        if (MHp == 0)
        {
            Destroy(gameObject);
            Debug.Log("dead");
        }
    }

 


    
}
