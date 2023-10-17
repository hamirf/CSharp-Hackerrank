public class Program
{
    static void Main()
    {
        Console.Write("Input number of players in the leaderboard: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Input leaderboard scores: ");
        List<int> ranked = Array.ConvertAll(Console.ReadLine()!.Split(" "), Convert.ToInt32).ToList();
        
        Console.Write("Input number of games the player plays: ");
        int m = int.Parse(Console.ReadLine()!);

        Console.Write("Input player's game scores: ");
        List<int> player = Array.ConvertAll(Console.ReadLine()!.Split(" "), Convert.ToInt32).ToList();

        List<int> ranks = ClimbingTheLeaderboard(ranked, player);

        foreach (var rank in ranks)
        {
            Console.WriteLine("Rank: " + rank);
        }
    }

    private static List<int> ClimbingTheLeaderboard(List<int> ranked, List<int> player)
    {
        var ranks = new int[player.Count];

        int index = player.Count - 1;
        int scoreNow = 0;
        int rankNow = 0;
        foreach (var rankedScore in ranked)
        {
            if (rankedScore != scoreNow)
            {
                scoreNow = rankedScore;
                rankNow++;
            }

            if (player[index] >= rankedScore)
            {
                ranks.SetValue(rankNow, index);
                index--;
            }
            if (player[index] < rankedScore)
            {
                rankNow++;
                ranks.SetValue(rankNow, index);
                index--;
            }

            if (index < 0)
            {
                break;
            }
        }

        return ranks.ToList();
    }
}