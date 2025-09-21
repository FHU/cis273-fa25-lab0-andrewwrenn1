namespace Uno;

public class Player
{
    public string Name { get; set; } = "";

    public List<Card> Hand { get; set; } = new List<Card>();


    public bool HasPlayableCard(Card card)
    {
        return Hand.Any(c => Card.PlaysOn(c, card));
    }

    public Card? GetFirstPlayableCard(Card card)
    {
        return Hand.FirstOrDefault(c => Card.PlaysOn(c, card));
    }


    public Color MostCommonColor()
    {
        return Color.Red;
    }

}