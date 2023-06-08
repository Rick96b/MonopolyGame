using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyGame.Controller.States;

namespace MonopolyGame.Controller
{
    public static class StateMachine
    {
        public static State CurrentState;
        public static Dictionary<string, State> States = new Dictionary<string, State>();
        public static EndGameState endGameState;
        private static EndTurnState endTurnState;
        private static PlayerLandedState playerLandedState;
        private static PlayerMoveState playerMoveState;
        private static PlayerRollState playerRollState;
        private static PlayerTurnState playerTurnState;
        private static InitialState initialState;

        public static void Initialize()
        {
            endGameState = new EndGameState(initialState);
            endTurnState = new EndTurnState(playerTurnState);
            playerLandedState = new PlayerLandedState(endTurnState);
            playerMoveState = new PlayerMoveState(playerLandedState);
            playerRollState = new PlayerRollState(playerMoveState);
            playerTurnState = new PlayerTurnState(playerRollState);
            initialState = new InitialState(playerTurnState);
            endTurnState.NextState = playerTurnState;
            endGameState.NextState = initialState;

            States.Add("InitialState", initialState);
            States.Add("PlayerTurnState", playerTurnState);
            States.Add("PlayerRollState", playerRollState);
            States.Add("PlayerMoveState", playerMoveState);
            States.Add("PlayerLandedState", playerLandedState);
            States.Add("EndTurnState", endTurnState);
            States.Add("EndGameState", endGameState);
        }

        public static void ChangeState()
        {
            CurrentState = CurrentState.NextState;
        }

        public static void EndGame()
        {
            CurrentState = endGameState;
            CurrentState.Execute();
        }
    }
}
