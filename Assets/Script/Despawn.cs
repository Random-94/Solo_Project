using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    // on apelle une fonction qui detecte quand un objet est traversé, 
    // other on peut l'appeller comme on veut
    {

        Debug.Log("lol");
        // on affiche un message dans la console, quand la fonction est vérifié
        // le compteur fonctionne et il affiche "pumpkin detected" dans la console

        if (other.gameObject.CompareTag("bullet"))
        // on appelle la variable qu'on a mis dans la fonction avec l'objet et le tag qu'on à mis a nos collectibles
        {

            Destroy(other.gameObject);
           
            /* on peut ecrire aussi : 
            scoreValue ++;
            ScoreValue = ScoreValue +1;
            */
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
