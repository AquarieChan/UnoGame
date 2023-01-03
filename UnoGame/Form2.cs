using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnoGame.Repositories;
using UnoGame.Services;

namespace UnoGame
{
    public partial class Form2 : Form
    {
        readonly Logic logic = new Logic();
        readonly ArtificialIntelligenceService ai = new ArtificialIntelligenceService();

        public Form2(int playerCount, int botCount)
        {
            InitializeComponent();

            var setup = new SetupCards();
            var cards = setup.Run();
            var table = new Table(setup.setupCardStack(cards), new TakeStack(cards), new Rotation(), new Players(playerCount, botCount, new Sort().Hands(logic.StartGame(cards, playerCount + botCount))));

            NextPlayer(0, table);
        }

        private void NextPlayer(int currentPlayerIndex, Table table)
        {
            var direction = table.rotation.Get();
            var players = table.players.GetPlayers();

            if (players.Count <= 1) return;

            currentPlayerIndex = GetCurrentPlayer(currentPlayerIndex, players.Count, direction);

            var playerCards = table.players.GetPlayerHands()[currentPlayerIndex].GetPlayerCards();
            var currentPlayer = table.players.GetPlayers()[currentPlayerIndex];

            Console.WriteLine();
            Console.WriteLine(currentPlayer.GetName());
            Console.WriteLine("Stack: " + table.cardStack.GetRealLast().GetColor() + " " + table.cardStack.GetRealLast().GetSymbol());
            Print(playerCards);

            if (!logic.CheckAndRunEventsThenSkip(table, currentPlayerIndex, currentPlayer.GetBot()))
            {
                #nullable enable
                Card? card = null;
                string? command = null;
                if (!currentPlayer.GetBot()) command = GetUserCommand();
                else card = ai.determineMove(table, currentPlayerIndex);

                if (command != null && command == "place") card = playerCards[GetCardIndex()];

                if (!logic.evaluate(table, currentPlayerIndex, card, currentPlayer.GetBot())) NextPlayer(currentPlayerIndex, table);
            }

            if (table.players.GetPlayerHands()[currentPlayerIndex].GetPlayerCards().Count == 0) PrintFinishAndDeletePlayer(currentPlayerIndex, table);

            if (direction != table.rotation.Get() && !table.rotation.Get()) NextPlayer(currentPlayerIndex - 2, table);
            else if (table.rotation.Get()) NextPlayer(currentPlayerIndex + 1, table);
            else NextPlayer(currentPlayerIndex - 1, table);

            NextPlayer(currentPlayerIndex + 1, table);
        }

        private static int GetCurrentPlayer(int currentPlayerIndex, int playerCount, bool clockwiseRotation)
        {
            if (currentPlayerIndex >= playerCount && !clockwiseRotation || currentPlayerIndex < 0) return playerCount - 1;
            else if (currentPlayerIndex >= playerCount) return 0;
            else return currentPlayerIndex;
        }

        private static void PrintFinishAndDeletePlayer(int currentPlayerIndex, Table table)
        {
            var players = table.players.GetPlayers();
            var currentPlayer = players[currentPlayerIndex];
            players.Remove(currentPlayer);
            var hands = table.players.GetPlayerHands();
            hands.Remove(hands[currentPlayerIndex]);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"        {currentPlayer.GetName()}: UNO UNO!");
            Console.WriteLine("------------------------------------------");
        }

        private static int GetCardIndex()
        {
            Console.WriteLine("Gib den Index der gewählten Karte ein: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private string GetUserCommand()
        {
            Console.WriteLine("Gib deine Aktion ein (place, take): ");
            return Console.ReadLine();
        }

        private static void Print(List<Card> playerCards)
        {
            Console.WriteLine("Die Karten deiner Hand sind: ");

            foreach (var card in playerCards)
            {
                Console.WriteLine(card.GetColor() + " " + card.GetSymbol());
            }
        }
    }
}