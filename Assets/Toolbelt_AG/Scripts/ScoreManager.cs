using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Toolbelt_AG
{
    public class ScoreManager : Singleton
    {
        public static int playerScore;
        public static int highScore;

        public TMPro.TextMeshProUGUI scoreUI;

        public void AddScore(int amount)
        {
            playerScore += amount;
            UpdateUI();
            Debug.Log("Added Score from " + gameObject.name);
        }

        public void SetHighScore()
        {
            // TODO 16/06/2022 14:45 - Make this save to a FILE on the computer.
            highScore = playerScore;
            UpdateUI();
        }

        public int GetHighScore()
        {
            return highScore;
        }

        private void UpdateUI()
        {
            scoreUI.text = playerScore.ToString();
        }

        /* What would you need?
         * 
         * make it a SINGLETON
         * 
         * score (variable: int?)
         * 
         * minimum/maximum score
         * UI component/element?
         * -- Text score object?
         * 
         * perhaps a multiplier?
         * 
         * methods to add to or remove from a player's score
         * 
         * event functionality that reacts when things happen
         * - OnScoreChange, doX
         * 
         */
    }
}
