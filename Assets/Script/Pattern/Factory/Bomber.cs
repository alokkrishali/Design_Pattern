using System.Collections;
using UnityEngine;

namespace Assets.Script.Pattern.Factory
{
    public class Bomber : IEnemy
    {
        public void enemyHealth()
        {
            throw new System.NotImplementedException();
        }

        public void enemyMaxHit()
        {
            throw new System.NotImplementedException();
        }

        public void enemyPower()
        {
            throw new System.NotImplementedException();
        }

        public string enemyType()
        {
            return "Bomber";
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}