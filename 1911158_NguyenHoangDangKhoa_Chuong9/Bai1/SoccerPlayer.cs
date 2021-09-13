using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class SoccerPlayer
    {
        public string playerName;
        public int jerseyNumber;
        public int goalScore;
        public int assists;

        public SoccerPlayer()
        {

        }

        public SoccerPlayer(string PlayerName, int JerseyNumber, int GoalScore, int Assists)
        {
            playerName = PlayerName;
            jerseyNumber = JerseyNumber;
            goalScore = GoalScore;
            assists = Assists;
        }

        public void Nhap()
        {
            Console.Write("Player Name: ");
            playerName = Console.ReadLine();
            Console.Write("Jersey Number: ");
            jerseyNumber = int.Parse(Console.ReadLine());
            Console.Write("Goal Score: ");
            goalScore = int.Parse(Console.ReadLine());
            Console.Write("Assists: ");
            assists = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return string.Format("Player Name: {0}\n" + "Jersey Number: {1}\n" + "Goal Score: {2}\n" + "Assists: {3}",
                                playerName, jerseyNumber, goalScore, assists);
        }
    }
}
