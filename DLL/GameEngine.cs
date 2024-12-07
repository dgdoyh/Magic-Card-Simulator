// 2023-04-10 / Yeonhee Do / 2211198 / Made GameEngine class

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class GameEngine
    {
        // Each card type has 13 cards
        const byte NUM_OF_CARDS_FOR_EACH_CARDTYPE = 13;

        // This contains every players
        public List<Player> players = new List<Player>();
        // This can be modified (when players lose, they are removed from this)
        public Queue<Player> playerQueue = new Queue<Player>();

        // This contains every cards
        Card[] cards;
        // These can be modified (every time when a card is drawed)
        // Draw pile where user can draw cards from
        public Stack<Card> drawPile = new Stack<Card>();
        // Player's card deck. When user draws cards, one card goes to each players' decks
        public Stack<Card> p1Pile = new Stack<Card>();
        public Stack<Card> p2Pile = new Stack<Card>();

        // Round number. It's increased when a new round is started
        public byte roundNumber = 1;

        // This will decide number of cards when it's created based on the parameter (Use joker)
        public GameEngine(bool useJoker)
        {
            try
            {
                // If user didn't check [Use Joker]
                if (!useJoker)
                {
                    // Total number of cards = 52 (without Jokers)
                    cards = new Card[52];
                    // Create 52 cards without Jokers and put it in the cards array
                    CreateCards();
                }
                // If user checked [Use Joker]
                else
                {
                    // Total number of cards = 54 (with Jokers)
                    cards = new Card[54];
                    // Create 52 cards without Joker and put it in the cards array
                    CreateCards();

                    // Add 2 Joker cards at the end of the cards list
                    cards[52] = new Card(14, CardType.Joker);
                    cards[52].cardImage = 52;
                    cards[53] = new Card(14, CardType.Joker);
                    cards[53].cardImage = 53;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        // Create cards and put value, card type and image into them
        private void CreateCards()
        {
            try
            {
                // Repeat 13 times
                for (byte i = 1; i <= NUM_OF_CARDS_FOR_EACH_CARDTYPE; i++)
                {
                    // Make heart cards (index: 0~12)
                    cards[i - 1] = new Card(i, CardType.Heart);
                    // Card image will match with the card image list in order
                    cards[i - 1].cardImage = (byte)(i - 1);

                    // Make diamond cards (index: 13~25)
                    cards[i + 12] = new Card(i, CardType.Diamond);
                    // Card image will match with the card image list in order
                    cards[i + 12].cardImage = (byte)(i + 12);

                    // Make clubs cards (index: 26~38)
                    cards[i + 25] = new Card(i, CardType.Clubs);
                    // Card image will match with the card image list in order
                    cards[i + 25].cardImage = (byte)(i + 25);

                    // Make spade cards (index: 39~51)
                    cards[i + 38] = new Card(i, CardType.Spade);
                    // Card image will match with the card image list in order
                    cards[i + 38].cardImage = (byte)(i + 38);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }        
        }

        // Shuffle cards and put them into a new draw pile
        public void ShuffleCards()
        {
            try
            {
                // Clear draw pile before shuffle cards
                drawPile.Clear();

                // Repeat until all cards are shuffled
                for (int i = 0; i < cards.Length; i++)
                {
                    // Generate a random index
                    int randomIndex = RNG.randomGenerator.Next(cards.Length);

                    // Shuffle a card and another card at random index
                    // Put the value of cards[i] into the temp
                    Card temp = cards[i];
                    // Put the value of cards[random index] to cards[i] => cards[i] has cards[randomIndex] value
                    cards[i] = cards[randomIndex];
                    // Put the value of temp to cards[randomIndex] => cards[randomIndex] has cards[i] value
                    cards[randomIndex] = temp;

                    // Put the card into a new draw pile
                    drawPile.Push(cards[i]);
                }
                // Reset all players' cards pile
                p1Pile.Clear();
                p2Pile.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        // Draw cards and put them in each players' pile
        public void DrawCards()
        {
            try
            {
                // Draw 2 cards and put them in each players' pile
                p1Pile.Push(drawPile.Pop());
                p2Pile.Push(drawPile.Pop());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Calculate players' score and rank players
        public void RankPlayers()
        {
            try
            {
                // Check every player in players
                foreach (Player player in players)
                {   
                    // 1 win = 1 player score 
                    player.playerScore += player.playerWins;
                    // 1 draw = 0.5 player score
                    player.playerScore += (player.playerDraws / 2);
                }

                // Change players order based on their score
                // This is previous player's index
                for (int i = 0; i < players.Count; i++)
                {   
                    // This is next player's index
                    for (int j = i + 1; j < players.Count; j++)
                    {
                        // If the next player's score is bigger than previous player's score
                        if (players[j].playerScore > players[i].playerScore)
                        {
                            // Change their orders
                            Player temp = players[j];
                            players[j] = players[i];
                            players[i] = temp;
                        }
                    }
                }

                // This is previous player's index
                for (int i = 0; i < players.Count; i++)
                {
                    // This is next player's index
                    for (int j = i + 1; j < players.Count; j++)
                    {
                        // If previous and next players' scores are same
                        if (players[j].playerScore == players[i].playerScore)
                        {   
                            // Compare their loses point
                            // If the next player lost more than the previous player, change order
                            if (players[j].playerLoses < players[i].playerLoses)
                            {
                                Player temp = players[j];
                                players[j] = players[i];
                                players[i] = temp;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }         
        }

        // Save favorite players
        public void SerializePlayers()
        {
            try
            {
                // If there's already the same binary file(bPlayers.bin), open it
                // If not, create new one
                using (Stream myStream = File.OpenWrite("bPlayers.bin"))
                {
                    // Create binary formatter to serialize
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    // Serialize the players and save into the binary file
                    binaryFormatter.Serialize(myStream, players);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Add saved favorite players into players list
        public void DeserializePlayers()
        {
            try
            {
                // Open the binary file(bPlayers.bin)
                using (Stream myStream = File.OpenRead("bPlayers.bin"))
                {
                    // Create binary formatter to deserialize
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    // Clear players list to contain new list
                    players.Clear();
                    // Deserialize the binary file and put the result list into the players list
                    players = (List<Player>)binaryFormatter.Deserialize(myStream);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
