using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public int numeroMax = 10;

    List<int> list = new List<int> { };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Contenuto lista:");
        list.Insert(0, 0);
        foreach (int list in list)
        {

            Debug.Log(list);

        }
        Debug.Log("Contenuto lista:");

        list.Add(1);
        foreach (int list in list)
        {
            Debug.Log(list);

        }
        Debug.Log("Contenuto lista:");

        int posizioneMedia = list.Count / 2;
        list.Insert(posizioneMedia, (2));
        foreach (int list in list)
        {
            Debug.Log(list);
        }
        Debug.Log("Contenuto lista:");
        list.Insert(0, 3);
        foreach (int list in list)
        {
            Debug.Log(list);
        }
        Debug.Log("Contenuto lista:");
        list.Add(4);
        foreach (int list in list)
        {
            Debug.Log(list);
        }

        int posizioneMedia2 = list.Count / 2;
        list.Insert(posizioneMedia2, (5));
        foreach (int list in list)
        {
            Debug.Log(list);
        }
        Debug.Log("Contenuto lista:");
        list.Insert(0, 6);
        foreach (int list in list)
        {
            Debug.Log(list);
        }
        Debug.Log("Contenuto lista:");
        list.Add(7);
        foreach (int list in list)
        {
            Debug.Log(list);
        }
        Debug.Log("Contenuto lista:");
        int posizioneMedia3 = list.Count / 2;
        list.Insert(posizioneMedia3, (8));
        foreach (int list in list)
        {
            Debug.Log(list);
        }
        Debug.Log("Contenuto lista:");
        list.Insert(0, 9);

        foreach (int list in list)
        {
            Debug.Log(list);
        }
        Debug.Log("Fine lista");


    }

    // Update is called once per frame
    void Update()
    {

    }
}
