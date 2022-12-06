using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
   
    
    void Start()
    {
        StartCoroutine(routine: OnCollisionEnter());
    }
    [SerializeField] int health = 3;
    private void Damage(){
        
        health--;
        if(health <= 0){
            Destroy(this.gameObject);
        }
        StartCoroutine(OnCollisionEnter());
    }

    IEnumerator OnCollisionEnter(Collision other) {
        if(other.body.CompareTag("Cube")){
           Damage();
           yield return new WaitForSeconds (3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
