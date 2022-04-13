using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Player"){
            Stopwatch.stopTimer();
            GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
            GameObject.Find("Player").GetComponent<MeshRenderer>().enabled = false;
            Invoke(nameof(enableMovement), 2f);
            Invoke(nameof(helperStartTimer), 2f);
            Invoke(nameof(loadNewScene), 2f);
        }
        
    }
    void helperStartTimer(){
        Stopwatch.startTimer();
    }
    void loadNewScene(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void enableMovement(){
        GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = true;
        GameObject.Find("Player").GetComponent<MeshRenderer>().enabled = true;
    }
}
