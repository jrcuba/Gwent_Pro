using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salirdeljuego : MonoBehaviour
{
    public void salir()
    {
        Debug.Log("ha salido del juego con exito");
        Application.Quit();
    }
}
