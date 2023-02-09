using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class towermaster : MonoBehaviour
{ protected string Name
    { get; set; }
    protected int Hp { get; set; }
    protected int Dmg { get; set; }     
        
    protected int Cost { get; set; }    
    public GameObject monster;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Hp == 0)
        {
            Destroy(gameObject);
        }
        
    }

    public void Attack()
    {
        //hit.gameObject.SetActive(false);
        RaycastHit2D hit = Physics2D.Raycast(Vector2.right, Vector2.zero);
        //hit.collider != null
        if (monster.CompareTag("monster") && hit.collider != null)
        {
            monsterHp = monsterHp - Dmg;
            Debug.Log("hit " + Dmg);
        }
        else
        {
            Debug.Log("miss hit");
        }
    }
    
    public int monsterHp = 30;
    //public void OnTriggerStay(Collider monster)
    public void OnTriggerEnter(Collider monster)
    {
        /*//hit.gameObject.SetActive(false);
        RaycastHit2D hit = Physics2D.Raycast(Vector2.up, Vector2.zero);
        //hit.collider != null
        if ( monster.CompareTag("monster"))
        {
            monsterHp = monsterHp-Dmg;
            Debug.Log("hit");
        }
        else
        {
            Debug.Log("miss hit");
        }*/
    }
}
