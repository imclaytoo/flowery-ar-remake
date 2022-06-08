using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonShop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenURL()
    {
        Application.OpenURL("https://tokopedia.com/");
        Debug.Log("Shop Link Work!");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("1_MainMenu");
    }
}
