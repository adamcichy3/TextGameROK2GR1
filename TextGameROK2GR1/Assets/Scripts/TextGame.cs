using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    // Program zgaduje liczbe ktora wymyslilismy sobie z konkretnego przedzialu liczbowego.
    // Mamy przedzial od 1 do 1000 i program pyta czy wymyslona liczba jest wieksza lub mniejsza lub rowna  - np. 328
    // No i uzytkownik odpowiada wieksza lud mniejsza lub rowna
    // ALGORYTM -> Wyszukiwanie binarnie -> losowo

    // 500
    // 328
    // mniejsza
    // min = 1 max = 500
    // (min + max) /2  = 501/2= 250

    int min = 1;
    int max = 1000;
    int shoot = 500;



    void Start()
    {
        // typ nazwe i ew. podac poczatkowa wartosc
        Debug.Log("Witam w grze - pomysl w glowie liczbe od "+min+ " do " + max);
        max = 1001;
        Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od 500?");
        // print string
        // Nacisnij gorna strzalke aby odpowiedziec ze wieksza
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            NextShoot();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            NextShoot();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("KOMPUTER ZGADL LICZBE");
        }
    }

    void NextShoot()
    {
        shoot = (min + max) / 2;
        Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od " + shoot + " ?");
    }


}
