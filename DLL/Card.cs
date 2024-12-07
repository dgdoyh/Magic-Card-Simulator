// 2023-04-10 / Yeonhee Do / 2211198 / Made card class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public enum CardType
    {
        Heart, Diamond, Clubs, Spade, Joker
    }

    public class Card
    {
        // numerical card value (1~14 with joker)
        public byte cardValue { get; private set; }
        // card image number. This will be used as an index of card image list
        public byte cardImage;
        public CardType cardType { get; private set; }

        public Card(byte newCardValue, CardType newCardType)
        {
            try
            {   // Initialize new Card with a certain card value and a certain card type
                cardValue = newCardValue;
                cardType = newCardType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public string DisplayableCardValue(byte value)
        {   // Convert numeric card value to string
            try
            {
                // Card value 1 = A
                if (value == 1)
                {
                    return "A";
                }
                // Card value 11 = J
                if (value == 11)
                {
                    return "J";
                }
                // Card value 12 = Q
                if (value == 12)
                {
                    return "Q";
                }
                // Card value 13 = K
                if (value == 13)
                {
                    return "K";
                }
                // Card value 14 = Joker
                if (value == 14)
                {
                    return "Joker";
                }
                else
                {   // if the value is 2~10, it just returns number with string type
                    return value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
