using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private  PlayerManager playerManager;
    public float movementSpeed;
    public float controlSpeed;

    private void FixedUpdate() {
        
        Move();
    }

   private void Move()
   {
       transform.position+=Vector3.forward*movementSpeed*Time.fixedDeltaTime;
       if(Input.GetMouseButton(0))
       {
           transform.position+=Vector3.left*controlSpeed*Time.fixedDeltaTime;
       }
       else if(Input.GetMouseButton(1)) 
       {
           transform.position+=Vector3.right*controlSpeed*Time.fixedDeltaTime;
       }
   }
}
