using UnityEngine;

public class Gravity : MonoBehaviour
{

    [SerializeField] private float ArcThreshold = 1;
    [SerializeField] private float ArcMult = 1;
    [SerializeField] private float FallSpeed = 1 ;
    [SerializeField] private float MaxFallSpeed = 1;
    private Rigidbody2D RigidBody;

    public void Awake()
    {
        RigidBody = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        float arcMult = ShouldArc(RigidBody.velocity) ? ArcMult : 1;
        RigidBody.velocity = RigidBody.velocity.MoveTowardsY(
            -MaxFallSpeed,
            FallSpeed * arcMult * Time.deltaTime
        );
    }

    private bool ShouldArc(Vector2 direction) => Mathf.Abs(direction.y) < ArcThreshold;
}
