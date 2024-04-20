using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaltarCinematica : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public void loadscene()
    {
        SceneManager.LoadScene("Scene2");
    }
}
