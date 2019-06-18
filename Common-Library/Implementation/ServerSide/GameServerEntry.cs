using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace CommonLibrary.Implementation.ServerSide
{
    /// <summary>
    /// Game Server registration data for Head Server
    /// </summary>
    [Serializable]
    public class GameServerEntry
    {
        public string Name { get; set; }
        public string CreatorName { get; set; }
        public bool IsActive { get; set; }
        public IPEndPoint Socket { get; set; }
        public int MaxPlayers { get; set; }

        public virtual int ExecuteInsertCommand(SqlConnection con)
        {
            using (SqlTransaction trans = con.BeginTransaction())
            using (SqlCommand insert_command = new SqlCommand("insert_game_server", con, trans) { CommandType = CommandType.StoredProcedure })
            {
                insert_command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
                insert_command.Parameters.Add("@max_players", SqlDbType.Int).Value = MaxPlayers;
                insert_command.Parameters.Add("@ip", SqlDbType.BigInt).Value = Socket.Address.Address;
                insert_command.Parameters.Add("@port", SqlDbType.Int).Value = Socket.Port;
                insert_command.Parameters.Add("@creator_name", SqlDbType.NVarChar).Value = CreatorName; //TODO
                insert_command.Parameters.Add("@enroll_time", SqlDbType.DateTime).Value = DateTime.UtcNow;
                insert_command.Parameters.Add("@is_active", SqlDbType.Bit).Value = IsActive ? 1 : 0;

                insert_command.Parameters.Add("@inserted_in_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                int result_count = insert_command.ExecuteNonQuery();
                bool not_inserted = (insert_command.Parameters["@inserted_in_id"].Value != DBNull.Value);
                if (result_count == 0 || not_inserted)
                {
                    trans.Rollback();
                    return -1;
                }
                trans.Commit();
                return (int)insert_command.Parameters["@inserted_in_id"].Value;
            }
        }
    }
}
