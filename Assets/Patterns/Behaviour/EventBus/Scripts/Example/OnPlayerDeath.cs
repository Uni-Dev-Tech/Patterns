namespace Patterns.EventBus.Example
{
    public class OnPlayerDeath
    {
        public int EnemyKilledCount { get; private set; }
        public float PlayerMaxDamage { get; private set; }
        public float SurvivedTime { get; private set; }

        public OnPlayerDeath(int enemyKilledCount, float playerMaxDamage, float survivedTime)
        {
            EnemyKilledCount = enemyKilledCount;
            PlayerMaxDamage = playerMaxDamage;
            SurvivedTime = survivedTime;
        }
    }
}