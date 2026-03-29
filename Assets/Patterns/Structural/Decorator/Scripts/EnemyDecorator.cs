namespace Patterns.Decorator
{
    public abstract class EnemyDecorator : IEnemy
    {
        protected IEnemy _enemy;

        public EnemyDecorator(IEnemy enemy)
        {
            _enemy = enemy;
        }

        public virtual void Attack()
        {
            _enemy.Attack();
        }
    }
}