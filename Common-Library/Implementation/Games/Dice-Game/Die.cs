
namespace CommonLibrary.Implementation.Games.Dice
{
    /// <summary>
    /// One die - has side (1-6 or JOKER) and keeps game state (Selected/Unselected)
    /// </summary>
    public enum DieSide { ONE, TWO, THREE, FOUR, FIVE, SIX, JOKER }
    public class Die
    {
        public bool Selected { get; set; }
        public DieSide Side { get; set; }

        public Die(DieSide side, bool is_selected = false)
        {
            Side = side;
            Selected = is_selected;
        }
    }
}
