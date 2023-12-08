using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambioPantalla : MonoBehaviour
{
    public void cargarEsena(string PantallaJuego)
    {
        SceneManager.LoadScene(PantallaJuego);
    }

}