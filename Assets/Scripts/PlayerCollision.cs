
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovent player;
    public ObstacleMovment movent;
    public ObstacleMovment movent1;
    public ObstacleMovment movent2;
    public ObstacleMovment movent3;
    public ObstacleMovment movent4;
    public ObstacleMovment movent5;
    public ObstacleMovment movent6;
    public ObstacleMovment movent7;
    public ObstacleMovment movent8;
    public ObstacleMovment movent9;
    public ObstacleMovment movent10;
    public ObstacleMovment movent11;
    public ObstacleMovment movent12;
    public ObstacleMovment movent13;
    public ObstacleMovment movent14;
    public ObstacleMovment movent15;
    public ObstacleMovment movent16;
    public ObstacleMovment movent17;
    public ObstacleMovment movent18;
    public ObstacleMovment movent19;


    public GameManager gameManager;
 


    void OnCollisionEnter(Collision collisionInfo) {


        if (collisionInfo.collider.name == "END")
        {
            Debug.Log("!!!!");
            gameManager.CompleteLevel();


        }






            if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerMovent>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        
            
            movent.enabled = false;
            movent.rb.drag = 1;
            movent.rb.freezeRotation = false;


            movent1.enabled = false;
            movent1.rb.drag = 1;
            movent1.rb.freezeRotation = false;


            movent2.enabled = false;
            movent2.rb.drag = 1;
            movent2.rb.freezeRotation = false;


            movent3.enabled = false;
            movent3.rb.drag = 1;
            movent3.rb.freezeRotation = false;


            movent4.enabled = false;
            movent4.rb.drag = 1;
            movent4.rb.freezeRotation = false;

            movent5.enabled = false;
            movent5.rb.drag = 1;
            movent5.rb.freezeRotation = false;

            movent6.enabled = false;
            movent6.rb.drag = 1;
            movent6.rb.freezeRotation = false;

            movent7.enabled = false;
            movent7.rb.drag = 1;
            movent7.rb.freezeRotation = false;

            movent8.enabled = false;
            movent8.rb.drag = 1;
            movent8.rb.freezeRotation = false;

            movent9.enabled = false;
            movent9.rb.drag = 1;
            movent9.rb.freezeRotation = false;

            movent10.enabled = false;
            movent10.rb.drag = 1;
            movent10.rb.freezeRotation = false;

            movent11.enabled = false;
            movent11.rb.drag = 1;
            movent11.rb.freezeRotation = false;

            movent12.enabled = false;
            movent12.rb.drag = 1;
            movent12.rb.freezeRotation = false;

            movent13.enabled = false;
            movent13.rb.drag = 1;
            movent13.rb.freezeRotation = false;

            movent14.enabled = false;
            movent14.rb.drag = 1;
            movent14.rb.freezeRotation = false;

            movent15.enabled = false;
            movent15.rb.drag = 1;
            movent15.rb.freezeRotation = false;

            movent16.enabled = false;
            movent16.rb.drag = 1;
            movent16.rb.freezeRotation = false;

            movent17.enabled = false;
            movent17.rb.drag = 1;
            movent17.rb.freezeRotation = false;


            movent18.enabled = false;
            movent18.rb.drag = 1;
            movent18.rb.freezeRotation = false;



            movent19.enabled = false;
            movent19.rb.drag = 1;
            movent19.rb.freezeRotation = false;


            Debug.Log("Çarptı");
        }


      



        }
}
