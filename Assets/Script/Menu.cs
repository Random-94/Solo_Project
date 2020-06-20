using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void playBouton()
    {
        SceneManager.LoadScene("SampleScene");//Charge la scène du jeu
    }

}
