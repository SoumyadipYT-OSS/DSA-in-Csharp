using System;

/*
    The Action Delegate:
    - The Action delegate is a built-in delegate type and is defined in the System namespace.
    - The Action delegate is a predefined delegate type and is used to encapsulate 
        a method that takes no parameters and returns void.
    - The Action delegate can encapsulate a method that takes up to 16 input parameters.


    The delegate keyword:
    - The delegate keyword is used to declare a delegate.
    - A delegate is a type that represents references to methods with a 
       particular parameter list and return type.
    - When you instantiate a delegate, you can associate its instance 
       with any method with a compatible signature and return type.
    - You can invoke (or call) the method through the delegate instance.
 */

namespace Events_Action_Delegate {
    struct FootballerStatus {
        private string playerName;
        private string position;
        private int goals;


        public string Player_Name {
            get {
                return playerName;
            } set {
                playerName = value;
                playerDetails(playerName);
            }
        }
        public string SuitablePosition {
            get {
                return position;
            } set {
                position = value;
                playerDetails(position);
            }
        }
        public int scoredGoals {
            get {
                return goals;
            } set {
                goals = value;
                playerAchievements(goals);
            }
        }
        
        // event handler using Action delegate
        public Action<string> playerDetails;
        public Action<int> playerAchievements;
    }


    
    public class Solution {
        static void Main(string[] args) {

            FootballerStatus player = new FootballerStatus();

            player.playerDetails += playerDetailsHandler;
            player.playerAchievements += playerAchievementsHandler;

            player.Player_Name = "Lionel Messi";
            player.SuitablePosition = "RWF";
            player.scoredGoals = 700;



            FootballerStatus player1 = new FootballerStatus();

            player1.playerDetails += playerDetailsHandler;
            player1.playerAchievements += playerAchievementsHandler;

            player1.Player_Name = "Cristiano Ronaldo";
            player1.SuitablePosition = "LWF or CF";
            player1.scoredGoals = 800;
        }



        // Event handler methods
        static void playerDetailsHandler(string player) {
            Console.WriteLine("Player Name: {0}", player);
        }

        static void playerAchievementsHandler(int goals) {
            Console.WriteLine("Goals Scored: {0}", goals);
        }
    }
}