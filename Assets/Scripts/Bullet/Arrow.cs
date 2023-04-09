using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Bullet
{
    [SerializeField] protected int _damage;
    [Header("Movement")]
    [SerializeField] protected Vector2 _direction;
    [SerializeField] protected float _moveSpeed;
    [SerializeField] protected bool _isMoving;

    public void MoveStraight(Vector2 direction, float moveSpeed)
    {
        _direction = direction;
        _moveSpeed = moveSpeed;
        _isMoving = true;
        StartCoroutine(UpdateMoveStraight());
    }

    private IEnumerator UpdateMoveStraight()
    {
        float duration = 0.1f;
        while (_isMoving)
        {
            yield return new WaitForSeconds(duration);
            transform.Translate(_direction * _moveSpeed);
        }
    }

    private void SendDamage(IDamageable receiver)
    {
        receiver.TakeDamage(_damage);
    }

    private void Detect()
    {
        float radius = 2f;
        LayerMask layers = LayerMask.GetMask("Enemy");
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius, layers);
        if (hit == null) return;

    }
}
