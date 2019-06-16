namespace CommonLibrary.Model.Common
{
    public interface IResetable
    {
        /// <summary>
        /// Rolls back all fields to initial state
        /// </summary>
        void Reset();
    }
}
