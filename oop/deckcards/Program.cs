using System;
using System.Globalization;
using System.Collections.Generic;

namespace deckcards
{
    class Program
    {
        public class Card
        {
            public string stringVal{get;set;}
            public string suit{get; set;}
            public int val{get;set;}
            public Card(string Stringval, string Suit, int Val){
                stringVal = Stringval;
                suit = Suit;
                val = Val;
            }
        }
        public class Deck
        {
            public List<Card> cards = new List<Card>();
            public Deck()
            {
                NewDeck();
            }
            public void NewDeck()
            {
                string [] suitarr = new string[4] {"Clubs", "Diamonds", "Spades", "Hearts"};
                string [] valarr = new string [13] {"Ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "Jack", "Queen", "King"};
                for(int i=0; i<valarr.Length; i++){
                    for(int j=0; j<suitarr.Length; j++){
                        Card newcard = new Card(valarr[i], suitarr[j], i+1);
                        cards.Add(newcard);
                    }
                }
            }
            public Card Deal(){
                Card deal = cards[0];
                cards.RemoveAt(0);
                return deal;
            }
            public void Rest(){
                cards.Clear();
                NewDeck();
            }
            public void Shuffle(){
                Random rand = new Random();
                for(int i = cards.Count -1; i>0; i--){
                    int n = rand.Next(i+1);
                    Card temp = cards[i];
                    cards[i] = cards[n];
                    cards[n] = temp;
                }
            }
        }
        public class Player {
            public string name {get; set;}
            List<Card> hand{get; set;} = new List<Card>();
            public Card Draw(Deck deckdraw){
                Card newCard = deckdraw.Deal();
                hand.Add(newCard);
                return newCard;
            }
            public Card Discard(int index){
                if(index > hand.Count-1){
                    return null;
                }
                Card card = hand[index];
                hand.RemoveAt(index);
                return card;
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Deck Of Cards");
            Deck deckOfCards = new Deck();
            Player tester = new Player();
            deckOfCards.Shuffle();
            System.Console.WriteLine(tester.Draw(deckOfCards).stringVal);
            System.Console.WriteLine(tester.Draw(deckOfCards));
            System.Console.WriteLine(tester.Draw(deckOfCards));
            System.Console.WriteLine(tester.Discard(2));
        }
    }
}
