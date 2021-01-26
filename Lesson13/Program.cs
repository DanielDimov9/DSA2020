using System;
using System.Collections.Generic;

namespace Lesson13
{
    internal class Program
    {
        private static Random rand = new Random();

        private static void Main(string[] args)
        {
            TestShuffle52000Cards();
        }

        #region Core functions

        private static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.Write(card);
            }
            Console.WriteLine();
        }


        private static void PerformSingleExchange(List<Card> cards, int index)
        {
            int randomIndex = rand.Next(0, cards.Count);
            Card firstCard = cards[index];
            Card randomCard = cards[randomIndex];
            cards[index] = randomCard;
            cards[randomIndex] = firstCard;
        }

        private static void ShuffleCards(List<Card> cards)
        {
            if (cards.Count > 1)
            {
                for (int i = 0; i < cards.Count - 1; i++)
                {
                    PerformSingleExchange(cards, i);
                }
            }
        }

        #endregion Core functions

        #region Test functions

        private static void TestShuffle52000Cards()
        {
            List<Card> cards = new List<Card>();

            string[] allFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            Suit[] allSuits = new Suit[] { Suit.Club, Suit.Diamond, Suit.Heart, Suit.Spade };

            for (int i = 0; i < 1000; i++)
            {
                foreach (string face in allFaces)
                {
                    foreach (Suit suit in allSuits)
                    {
                        cards.Add(new Card() { Face = face, Suit = suit });
                    }
                }
            }
            ShuffleCards(cards);
            PrintCards(cards);
        }

        private static void TestShuffleTwoCards()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "A", Suit = Suit.Club });
            cards.Add(new Card() { Face = "3", Suit = Suit.Diamond });
            ShuffleCards(cards);
            PrintCards(cards);
        }

        private static void TestShuffleOneCard()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "A", Suit = Suit.Club });
            ShuffleCards(cards);
            PrintCards(cards);
        }

        private static void TestShuffle52Cards()
        {
            List<Card> cards = new List<Card>();

            string[] allFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            Suit[] allSuits = new Suit[] { Suit.Club, Suit.Diamond, Suit.Heart, Suit.Spade };

            foreach (string face in allFaces)
            {
                foreach (Suit suit in allSuits)
                {
                    Card card = new Card() { Face = face, Suit = suit };
                    cards.Add(card);
                }
            }
            //PrintCards(cards);
            ShuffleCards(cards);
            PrintCards(cards);
        }

        #endregion Test functions
    }
}
