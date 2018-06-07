using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class Selection : MonoBehaviour {
    private List<GameObject> players;
    private int selectionIndex = 0;

    private void Start()
    {
        players = new List<GameObject>();
        foreach (Transform t in transform) {
            players.Add(t.gameObject);
            t.gameObject.SetActive(false);
        }
        players[selectionIndex].SetActive(true);
    }
    private void Update()
    {
      
    }
    public void Select(int index) {
        if (index == selectionIndex)
            return;

        if (index < 0 || index<=players.Count)
            return;

        players[selectionIndex].SetActive(false);
        selectionIndex = index;
        players[selectionIndex].SetActive(true);
    }
   

}
