using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Pattern.Factory
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        string enemyType;
        IEnemy enemy;
        string enemyTypeOnCreate;
        // Start is called before the first frame update
        void Start()
        {

        }

        private void OnGUI()
        {
            if(GUI.Button(new Rect(100,100,100,50), "Create Enemy"))
            {
                enemy = EnemyFactory.GetEnemy(enemyType);

                enemyTypeOnCreate = enemy.enemyType();
                if (enemyTypeOnCreate != null)
                    Debug.Log(enemyTypeOnCreate);
            }
        }
    }

    public interface IEnemy
    {
        void enemyHealth();
        string enemyType();
        void enemyPower();
        void enemyMaxHit();

    }
}
