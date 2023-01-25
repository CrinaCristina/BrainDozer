using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Button PlayButtonRef;

    // Start is called before the first frame update
    void Start()
    {
        PlayButtonRef.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        // Dezactiveaza butonul Play (il va face invizibil in joc
        //      si nu se va mai putea interactiona cu el).
        PlayButtonRef.gameObject.SetActive(false);

        // Incarca primul nivel daca este un joc nou sau
        //      reia ultimul nivel salvat (daca s-a gasit unul).
        // TODO
    }
}
