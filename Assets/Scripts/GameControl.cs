using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public float puntos;
    public Text _texto;
    public void puntajeConstante()
    {
        puntos = puntos + 1;
        _texto.text = "Puntos: " + puntos.ToString();
    }
}
