using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class towermaster : MonoBehaviour
{ protected string Name
    { get; set; }
   public int Hp  { get; set; }
    protected int Dmg { get; set; }     
        
    protected int Cost { get; set; }    
    public GameObject monster1;
    public GameObject monster2;
    public GameObject monster3;
    public GameObject monster4;
    public GameObject monster5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

     
        
    }
    public void Dead()
    {
        if (Hp == 0)
        {
            Destroy(gameObject);
            Debug.Log("dead");
        }
    }

    public void Attack()
    {
        //hit.gameObject.SetActive(false);
        RaycastHit2D hit = Physics2D.Raycast(Vector2.right, Vector2.zero);
        //hit.collider != null
        if (monster1.CompareTag("monster") && hit.collider != null)
        {
            Hp = Hp - Dmg;
            Debug.Log("hit " + Dmg);
        }
        if (monster2.CompareTag("monster") && hit.collider != null)
        {
            Hp = Hp - Dmg;
            Debug.Log("hit " + Dmg);
        }
        if (monster3.CompareTag("monster") && hit.collider != null)
        {
            Hp = Hp - Dmg;
            Debug.Log("hit " + Dmg);
        }
        if (monster4.CompareTag("monster") && hit.collider != null)
        {
            Hp = Hp - Dmg;
            Debug.Log("hit " + Dmg);
        }
        if (monster5.CompareTag("monster") && hit.collider != null)
        {
            Hp = Hp - Dmg;
            Debug.Log("hit " + Dmg);
        }


        //else
        //{
        //    Debug.Log("miss hit");
        //}
    }
       
}
