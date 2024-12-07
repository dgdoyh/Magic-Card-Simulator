// 2023-04-10 / Yeonhee Do / 2211198 / Made Player class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    // You can serialize this class
    [Serializable]
    public class Player
    {
        // This can be used but cannot be set from other classes
        public string playerName { get; private set; }
        // This contains avatar index
        public byte playerAvatar { get; private set; }
        public byte playerHP;
        public byte playerWins;
        public byte playerLoses;
        public byte playerDraws;
        public double playerScore;

        // This is for serialization
        public Player() { }

        // Create player with new player name and new avatar index
        public Player(string newPlayerName, byte newPlayerAvatar)
        {
            try
            {
                // Initialize all the variables
                playerName = newPlayerName;
                playerAvatar = newPlayerAvatar;
                playerHP = 0;
                playerWins = 0;
                playerLoses = 0;
                playerDraws = 0;
                playerScore = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
