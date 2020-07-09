using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main : MonoBehaviour
{
    // Start is called before the first frame update
   public  void HandleInputData(int val){
        if(val==0){
            SceneManager.LoadScene("Constatan");
        }
        if(val==1){
            SceneManager.LoadScene("Hierro");
        }
        if(val==2){
            SceneManager.LoadScene("Nicron");
        }
    }
}
