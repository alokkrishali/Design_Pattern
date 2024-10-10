using System.Collections;
using UnityEngine;

namespace Assets.Script.Pattern.Factory
{
    public class EnemyFactory : MonoBehaviour
    {

        public static IEnemy GetEnemy(string enemyType)
        {
            if (enemyType.Equals("Boss"))
            {
                Debug.LogError("Boss created");
                return new Boss();
            }
            else if (enemyType.Equals("Bomber"))
            {
                Debug.LogError("Bomber created");
                return new Bomber();
            }
            else if (enemyType.Equals("Gunman"))
            {
                Debug.LogError("Gunman created");
                return new Gunman();
            }
            else if (enemyType.Equals("Thief"))
            {
                Debug.LogError("Thief created");
                return new Thief();
            }
            else
            {
                Debug.LogError("Nothing created");
                return null;
            }
        }
    }
}