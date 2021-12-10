using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public List<GameObject> Personen = new List<GameObject>();

    public int mensenAantal;
    public List<string> namen = new List<string>();

    public List<string> alleVoorNamen = new List<string>();
    public List<string> alleAchterNamen = new List<string>();

    public List<GameObject> legalItems = new List<GameObject>();
    public List<GameObject> illegalItems = new List<GameObject>();

    void Start()
    {
        genereerLijst();
    }

    void genereerLijst()
    {
        for (int i = 0; i < mensenAantal; i++)
        {
            do
            {
                string name = alleVoorNamen[Random.Range(0, alleVoorNamen.Count)] + " " + alleAchterNamen[Random.Range(0, alleAchterNamen.Count)];
            } while (namen.Contains(name));
            namen.Add(name);
        }
    }


}
