using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionarPersonajes : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;


    private void Start()
    {
        index = PlayerPrefs.GetInt("characterSelected");

        //Llenar matriz de jugadores
        characterList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)

            characterList[i] = transform.GetChild(i).gameObject;
        //Renderizado
        foreach (GameObject go in characterList)
            go.SetActive(false);
        //Alternamos el modelo seleccionado
        if (characterList[index])
            characterList[index].SetActive(true);


    }

    public void MoverAnterior()
    {
        //Desactivar el modelo actual
        characterList[index].SetActive(false);

        index--;//index -=1=index -1;
        if (index < 0)
            index = characterList.Length - 1;

        //Alternar el Nuevo modelo
        characterList[index].SetActive(true);

    }

    public void MoverSiguiente()
    {
        //Desactivar el modelo actual
        characterList[index].SetActive(false);

        index++;//index -=1=index -1;
        if (index == characterList.Length)
            index = 0;

        //Alternar el Nuevo modelo
        characterList[index].SetActive(true);

    }
    public void Confirmar() {
        PlayerPrefs.SetInt("characterSelected", index);
        SceneManager.LoadScene("Tienda");
            }
    public void Continuar()
    {
        PlayerPrefs.SetInt("characterSelected", index);
        SceneManager.LoadScene("Parque");
    }
    public void Continuar2()
    {
        PlayerPrefs.SetInt("characterSelected", index);
        SceneManager.LoadScene("Colegio");
    }
    public void Continuar3()
    {
        PlayerPrefs.SetInt("characterSelected", index);
        SceneManager.LoadScene("Casa");
    }
}
