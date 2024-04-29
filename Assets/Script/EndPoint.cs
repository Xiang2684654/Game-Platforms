using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("1", LoadSceneMode.Single);
        }
    }

    public void OnButtonRestart()
    {
        SceneManager.LoadScene("0", LoadSceneMode.Single);
    }
}
