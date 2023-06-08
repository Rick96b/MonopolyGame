using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Model.Players;

namespace MonopolyGame.Model.Tiles
{
    public class ChanceCardGenerator
    {
        private static readonly Random rng = new Random();
        private const int GO_POSITION = 0;
        private const int MAYFAIR_POSITION = 39;
        private const int BANK_MONEY_BONUS = 100;
        private const int PRETTY_BONUS = 50;

        private static List<Func<Player, string>> listOfChanceCards = new List<Func<Player, string>>
        {
            BankIsGivingYouMoney,
            YouArePrettyGivingBonus,
            GiveAmountToOtherPlayers
        };

        private static string BankIsGivingYouMoney(Player player)
        {
            player.IncrementMoney(BANK_MONEY_BONUS);
            return "\nБанк даёт вам 200$!";
        }

        private static string YouArePrettyGivingBonus(Player player)
        {
            player.IncrementMoney(PRETTY_BONUS);
            return "\nВы выйграли конкурс красоты. \nПолучите 50$";
        }

        private static string GiveAmountToOtherPlayers(Player player)
        {
            Board.players[Board.CurrentPlayerIndex].DecrementMoney(30);
            Board.players[(Board.CurrentPlayerIndex + 1) % 2].IncrementMoney(30);
            return "\nТы пожертвовал другим игрокам 30$";
        }

        public static string GenerateRandomCart(Player player)
        {
            listOfChanceCards = listOfChanceCards.OrderBy(x => rng.Next()).ToList();

            Func<Player, string> randomChanceCard = listOfChanceCards[rng.Next(0, 3)];

            return randomChanceCard.Invoke(player);
        }
    }
}
