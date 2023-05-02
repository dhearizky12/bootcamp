using System;
using NLog;
using NLog.Config;

namespace GameExample
{
    class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            // Load the NLog configuration from a different file
            var config = new XmlLoggingConfiguration("NLog.config");
            LogManager.Configuration = config;

            logger.Info("Game started.");

            int playerHealth = 100;
            int enemyHealth = 100;

            while (playerHealth > 0 && enemyHealth > 0)
            {
                // Player's turn
                logger.Info("Player's turn.");
                int playerAttack = GetRandomNumber(10, 20);
                logger.Info($"Player's attack: {playerAttack}");
                enemyHealth -= playerAttack;
                logger.Info($"Enemy's health: {enemyHealth}");

                if (enemyHealth <= 0)
                {
                    logger.Info("Player wins!");
                    break;
                }

                // Enemy's turn
                logger.Info("Enemy's turn.");
                int enemyAttack = GetRandomNumber(5, 15);
                logger.Info($"Enemy's attack: {enemyAttack}");
                playerHealth -= enemyAttack;
                logger.Info($"Player's health: {playerHealth}");

                if (playerHealth <= 0)
                {
                    logger.Info("Enemy wins!");
                    break;
                }
            }

            logger.Info("Game finished.");
        }

        static int GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
