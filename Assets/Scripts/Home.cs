using UnityEngine;

public class Home : MonoBehaviour
{
    [SerializeField] private Signalization _signalization;

    private void OnTriggerEnter(Collider colider)
    {
        if (colider.gameObject.TryGetComponent<Thief>(out Thief thief))
            _signalization.Play(true);
    }

    private void OnTriggerExit(Collider colider)
    {
        if (colider.gameObject.TryGetComponent<Thief>(out Thief thief))
            _signalization.Play(false);
    }
}
