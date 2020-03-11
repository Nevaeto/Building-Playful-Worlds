using UnityEngine;

public class CollisionBehaviour : MonoBehaviour
{
    // 1
    public bool collided;

    //2
    void OnCollisionEnter(Collision collision)
    {
        if (!collided)
        {
            collided = true;
            // 3
            GameObject clown = gameObject.transform.parent.gameObject;
            Animator clownAnimator = clown.GetComponent<Animator>();
            // 4
            clownAnimator.SetTrigger("hit");
        }
    }  
}
