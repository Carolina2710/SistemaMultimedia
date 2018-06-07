using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImportarTexto : MonoBehaviour {
    public TextAsset textFile;
    public string[] dialogLines;
    public int LineNumber;
    private string dialog;

    public Text uiText;
    public Canvas canvas;


	// Use this for initialization
	void Start () {
        if (textFile) {
            dialogLines = (textFile.text.Split("\n"[0]));
        }
	}

    // Update is called once per frame
   void Update() {
        if (LineNumber < 0) {
            LineNumber = 0;
        }
        string dialog = dialogLines[LineNumber];
        uiText.text = dialog;
            }

   public  void Next() {
        LineNumber += 1;
    }

   public void Back() {
        LineNumber -= 1;
    }

}
