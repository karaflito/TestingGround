using UnityEngine;

public class InputEventTester : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float amount;
    private IHealth health;


    private void Start()
    {
        if(target != null)
        {
            health = target.GetComponent<IHealth>();
            if (health == null )
            {
                Debug.LogError($"{target.name} does not imprement IHealth!  ");
            }
        }
    }

    public void OnDamageTest(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
    {
        if(ctx.performed && health != null)
           health.TakeDamage(amount);
        
    }

    public void OnHealTest (UnityEngine.InputSystem.InputAction.CallbackContext ctx)
    {
        if (ctx.performed && health != null)
            health.Heal(amount);
    }
}
