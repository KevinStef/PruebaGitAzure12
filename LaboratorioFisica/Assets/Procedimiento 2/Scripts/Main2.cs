using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main2 : MonoBehaviour
{
    // Start is called before the first frame update
    public  void HandleInputData(int val){
        if(val==0){
            SceneManager.LoadScene("Nicron");
        }
        if(val==1){
            SceneManager.LoadScene("Constatan");
        }
        if(val==2){
            SceneManager.LoadScene("Hierro");
        }
    }
}
