public class ScriptureGenerator
{
    private List<(Reference Reference, string Text)> _scriptures;
    private Random _random = new Random();

    public Scripture GetRandomScripture()
    {
        _scriptures = new List<(Reference Reference, string Text)>
        {
            (new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            (new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            (new Reference("1 Nephi", 2, 15), "And my father dwelt in a tent."),
            (new Reference("D&C", 121, 11), "And they who do charge thee with transgression, their hope shall be blasted, and their prospects shall melt away as the hoar frost melteth before the burning rays of the rising sun;"),
            (new Reference("Moses", 1, 9), "And the presence of God withdrew from Moses, that his glory was not upon Moses; and Moses was left unto himself. And as he was left unto himself, he fell unto the earth."),
        };
        int index = _random.Next(_scriptures.Count);
        var selected = _scriptures[index];
        return new Scripture(selected.Text, selected.Reference);
    }
}