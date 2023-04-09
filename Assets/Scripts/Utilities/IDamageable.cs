public interface IDamageable
{
    public int CurrentHealth { get; }
    public void TakeDamage(int damage);
}