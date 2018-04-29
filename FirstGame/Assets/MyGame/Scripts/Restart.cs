using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class Restart : MonoBehaviour
 {
   public int Difficulty = 3;

   void Update ()
   {
     if( Input.GetKeyDown(KeyCode.R) )
     {
         SceneManager.LoadScene( SceneManager.GetActiveScene().name );
     }
   }
     void Level()
    {
        switch (Difficulty)
        {
        case 3:
            print ("Very Hard");
            break;
        case 2:
            print ("Hard");
            break;
        case 1:
            print ("Normal");
            break;
        default:
            print (".Normal.");
            break;
        }
    }
 }
 //switchStatements
 //ifstatment