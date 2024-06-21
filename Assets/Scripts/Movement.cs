using UnityEngine;

public class Movement : MonoBehaviour
{
    private readonly string _horizontal = "Horizontal";
    private readonly string _vertical = "Vertical";

    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis(_horizontal), 0f, Input.GetAxis(_vertical));

        transform.Translate(_speed * direction * Time.deltaTime);
    }
}