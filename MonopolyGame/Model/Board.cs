using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Model.Players;
using MonopolyGame.Model.Tiles;
using MonopolyGame.Model.Enums;
using System.IO;

namespace MonopolyGame.Model
{
    public class Board
    {
        public static List<Player> players;
        public static List<Tile> allTiles;
        public static int CurrentPlayerIndex;

        public static void InitializeBoard()
        {
            CurrentPlayerIndex = 0;
            players = new List<Player>()
            {
                new Player(1),
                new Player(2)
            };
            allTiles = new List<Tile>
            {
                new SpecialTile(0, "ВПЕРЁД!"),
                new Street(1, "Житная улица", NeighbourhoodTypes.Brown, 60, 2),
                new ChanceCard(2, "Общественная казна"),
                new Street(3, "Нагатинская улица", NeighbourhoodTypes.Brown, 60, 2),
                new Tax(4, "Подоходный налог", 200),
                new Street(5, "Рижская жедезная дорога", NeighbourhoodTypes.Station, 200, 25),
                new Street(6, "Варшавское шоссе", NeighbourhoodTypes.Blue, 100, 6),
                new ChanceCard(7, "Шанс"),
                new Street(8, "Улица Огарева", NeighbourhoodTypes.Blue, 100, 6),
                new Street(9, "Первая парковая улица", NeighbourhoodTypes.Blue, 120, 8),
                new SpecialTile(10, "Тюрьма"),
                new Street(11, "Улица Полянка", NeighbourhoodTypes.Pink, 140, 10),
                new Street(12, "Электростанция", NeighbourhoodTypes.Utility, 150, 20),
                new Street(13, "Улица Снежная", NeighbourhoodTypes.Pink, 140, 10),
                new Street(14, "Ростовская набережная", NeighbourhoodTypes.Pink, 160, 12),
                new Street(15, "Курская железная дорога", NeighbourhoodTypes.Station, 200, 25),
                new Street(16, "Рязаский проспект", NeighbourhoodTypes.Orange, 180, 14),
                new ChanceCard(17, "Общественная казна"),
                new Street(18, "Улица Ванилова", NeighbourhoodTypes.Orange, 180, 14),
                new Street(19, "Рублевский проспект", NeighbourhoodTypes.Orange, 200, 16),
                new SpecialTile(20, "Бесплатная парковка"),
                new Street(21, "Улица Тверская", NeighbourhoodTypes.Red, 220, 18),
                new ChanceCard(22, "Шанс"),
                new Street(23, "Пушкинская улица", NeighbourhoodTypes.Red, 220, 18),
                new Street(24, "Площадь Маяковского", NeighbourhoodTypes.Red, 240, 22),
                new Street(25, "Казанская железная дорога", NeighbourhoodTypes.Station, 200, 25),
                new Street(26, "Улица Грузинский вал", NeighbourhoodTypes.Yellow, 260, 24),
                new Street(27, "Норильский бульвар", NeighbourhoodTypes.Yellow, 260, 24),
                new Street(28, "Водопровод", NeighbourhoodTypes.Utility, 150, 2),
                new Street(29, "Смоленская площадь", NeighbourhoodTypes.Yellow, 280, 26),
                new SpecialTile(30, "Отправляйся в тюрьму"),
                new Street(31, "Улица Щусева", NeighbourhoodTypes.Green, 300, 28),
                new Street(32, "Гоголевский бульвар", NeighbourhoodTypes.Green, 300, 28),
                new ChanceCard(33, "Общественная казна"),
                new Street(34, "Кутузовский проспект", NeighbourhoodTypes.Green, 300, 30),
                new Street(35, "Ленинская железна дорога", NeighbourhoodTypes.Station, 200, 25),
                new ChanceCard(36, "Шанс"),
                new Street(37, "Малая Бронная улица", NeighbourhoodTypes.DarkBlue, 350, 35),
                new Tax(38, "Общественный сбор", 100),
                new Street(39, "Улица Арбат", NeighbourhoodTypes.DarkBlue, 400, 50)
            };
        }
    }
}
