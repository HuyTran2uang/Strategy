using System.Globalization;
using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTower : Tower
{
    [SerializeField] protected Bullet _bulletPrefab;
    [SerializeField] protected int _attackPoint;

    private void Shoot(Enemy enemy)
    {
        // _bulletPrefab.MoveStraight()
    }

    protected virtual void Detect()
    {
        Vector3 position = transform.position;
        float radius = 2f;
        LayerMask layers = LayerMask.GetMask("Enemy");
        Collider2D hit = Physics2D.OverlapCircle(position, radius, layers);
        if (hit == null) return;
        //shoot
    }

    private void Reset()
    {
        _name = "Fire Tower";
    }
}
