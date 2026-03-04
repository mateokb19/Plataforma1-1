using UnityEngine;

public class CoinProximity : MonoBehaviour
{
    public Transform player;
    public float activationDistance = 3f;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance <= activationDistance)
        {
            animator.SetBool("PlayerNear", true);
        }
        else
        {
            animator.SetBool("PlayerNear", false);
        }
    }
}