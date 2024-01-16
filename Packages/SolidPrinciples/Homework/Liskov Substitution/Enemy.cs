
namespace RobotDreams.SolidPrinciples.Homework.Liscow
{
    public class Enemy
    {
        public virtual void Attack() { /*...*/ }
    }

    public class Boss : Enemy
    {
        public override void Attack() { /*...*/ }
        public void SpecialAttack() { /*...*/ }
    }

    public class Game
    {
        public void StartBattle(Enemy enemy)
        {
            enemy.Attack(); // This will fail if the enemy is a Boss and we want to use the SpecialAttack
        }
    }
}

