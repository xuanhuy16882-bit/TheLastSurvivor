namespace TheLastSurvivor
{
    public static class GameData
    {
        // Tên nhân vật
        public static string PlayerName { get; set; } = "";

        // Màn hiện tại
        public static int CurrentStage { get; set; } = 1;

        // Điểm
        public static int Score { get; set; } = 0;

        // Số zombie đã tiêu diệt
        public static int ZombieKills { get; set; } = 0;

        // Thời gian chơi
        public static int PlayTime { get; set; } = 0;

        // Xóa dữ liệu game
        public static void ResetGame()
        {
            PlayerName = "";
            CurrentStage = 1;
            Score = 0;
            ZombieKills = 0;
            PlayTime = 0;
        }
    }
}