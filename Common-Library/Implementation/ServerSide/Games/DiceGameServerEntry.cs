
using System.Data;
using System.Data.SqlClient;

namespace CommonLibrary.Implementation.ServerSide
{

    // ! Unused now

    /// <summary>
    /// Registration data of Dice Game Server 
    /// </summary>
    public class DiceGameServerEntry : GameServerEntry
    {
        public int? TurnTimeSec { get; set; }
        public int ScoreGoal { get; set; }
        public int DiceNumber { get; set; }
        public bool IsJokerAllowed { get; set; }

        public override int ExecuteInsertCommand(SqlConnection con)
        {
            int general_options_insert_id = base.ExecuteInsertCommand(con);
            if (general_options_insert_id == -1)
            {
                return -1;
            }
            using (SqlTransaction trans = con.BeginTransaction())
            using (SqlCommand insert_command = new SqlCommand("insert_dice_game_server_aposteori", con, trans) { CommandType = CommandType.StoredProcedure })
            {
                insert_command.Parameters.Add("@server_id", SqlDbType.Int).Value = general_options_insert_id;
                insert_command.Parameters.Add("@turn_time_sec", SqlDbType.SmallInt).Value = TurnTimeSec;
                insert_command.Parameters.Add("@score_goal", SqlDbType.Int).Value = ScoreGoal;
                insert_command.Parameters.Add("@dice_number", SqlDbType.Int).Value = DiceNumber;
                insert_command.Parameters.Add("@is_joker_allowed", SqlDbType.Bit).Value = IsJokerAllowed ? 1 : 0;

                int result_count = insert_command.ExecuteNonQuery();
                if (result_count == 0)
                {
                    trans.Rollback();
                    return -1;
                }
                trans.Commit();
                return 0;
            }
        }
    }
}
