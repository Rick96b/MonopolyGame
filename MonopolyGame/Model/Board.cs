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
                new SpecialTile(0, "старт"),
                new Street(1, "Автомат в РТФ", NeighbourhoodTypes.Brown, 100, 60),
                new ChanceCard(2, "Активности университета"),
                new Street(3, "Автомат в ГУКе", NeighbourhoodTypes.Brown, 125, 75),
                new Tax(4, "Сбор профсоюза", 200),
                new Street(5, "SubWay", NeighbourhoodTypes.JunkFood, 100, 50),
                new Street(6, "Патриот", NeighbourhoodTypes.Blue, 75, 10),
                new ChanceCard(7, "Шанс"),
                new Street(8, "Вилка Ложка", NeighbourhoodTypes.Blue, 75, 10),
                new Street(9, "АмНям", NeighbourhoodTypes.Blue, 100, 15),
                new SpecialTile(10, "Деканат"),
                new Street(11, "TomYumBar", NeighbourhoodTypes.Pink, 125, 25),
                new Street(12, "Электростанция", NeighbourhoodTypes.ElectricityStation, 125, 40),
                new Street(13, "Mio", NeighbourhoodTypes.Pink, 125, 40),
                new Street(14, "Sumo", NeighbourhoodTypes.Pink, 150, 40),
                new Street(15, "MacDonalds", NeighbourhoodTypes.JunkFood, 200, 50),
                new Street(16, "BreadWay", NeighbourhoodTypes.Orange, 175, 55),
                new ChanceCard(17, "Активности университета"),
                new Street(18, "Momo", NeighbourhoodTypes.Orange, 175, 70),
                new Street(19, "The Barbara", NeighbourhoodTypes.Orange, 200, 70),
                new SpecialTile(20, "Бесплатная парковка"),
                new Street(21, "Tako Mago", NeighbourhoodTypes.Red, 225, 85),
                new ChanceCard(22, "Шанс"),
                new Street(23, "Estory", NeighbourhoodTypes.Red, 225, 100),
                new Street(24, "Metis", NeighbourhoodTypes.Red, 250, 100),
                new Street(25, "KFC", NeighbourhoodTypes.JunkFood, 200, 50),
                new Street(26, "Dong Po", NeighbourhoodTypes.Yellow, 275, 115),
                new Street(27, "Kong Fu", NeighbourhoodTypes.Yellow, 275, 130),
                new Street(28, "Водопровод", NeighbourhoodTypes.WaterStation, 150, 2),
                new Street(29, "Jang Su", NeighbourhoodTypes.Yellow, 300, 130),
                new SpecialTile(30, "Отправляйся в тюрьму"),
                new Street(31, "Dolce Vita", NeighbourhoodTypes.Green, 325, 145),
                new Street(32, "Pinzeria", NeighbourhoodTypes.Green, 325, 160),
                new ChanceCard(33, "Активности университета"),
                new Street(34, "Donna Olivia", NeighbourhoodTypes.Green, 300, 30),
                new Street(35, "Burger King", NeighbourhoodTypes.JunkFood, 200, 50),
                new ChanceCard(36, "Шанс"),
                new Street(37, "Magellan", NeighbourhoodTypes.DarkBlue, 400, 185),
                new Tax(38, "Попал в УрФУ на платку", 0.5),
                new Street(39, "Panorama", NeighbourhoodTypes.DarkBlue, 450, 200)
            };
        }

        public static void AddStreetToPlayer(int streetIndex, int playerIndex)
        {
            Street currentStreet = (Street)allTiles[streetIndex];
            currentStreet.Owner = players[playerIndex];

            players[playerIndex].Streets.Add(currentStreet);
            players[playerIndex].DecrementMoney(currentStreet.Price);

        }
    }
}
