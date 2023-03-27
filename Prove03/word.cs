// Jayton Crockett and Michael Torres
// Splits the scripture into the words and blanks them out over time
public class Word
{
    List<string> jc_words = new List<string>();
    int count = 0;
    int jc_wordCount = 0;

    public void SplitAndAddWords(string scriptureText)
    {
        string[] jc_wordArray = scriptureText.Split(' ');
        foreach (string Word in jc_wordArray)
        {
            jc_words.Add(Word);
        }
    }

    public string GetVisibleScripture()
    {
        string visibleScripture = "";
        for (int i = 0; i < jc_words.Count; i++)
        {
            if ((i + 1) % 3 != 0 || jc_words[i] == "___")
            {
                visibleScripture += jc_words[i] + " ";
            }
            else
            {
                visibleScripture += "___ ";
            }
        }
        return visibleScripture;
    }

    public bool HandleEnterPressed()
    {
        count++;
        if (count % 3 == 0)
        {
            for (int i = 2; i < jc_words.Count; i += 3)
            {
                if (jc_words[i] != "___")
                {
                    jc_words[i] = "___";
                    jc_wordCount++;
                }
            }
            if (jc_wordCount == jc_words.Count / 3)
            {
                return false;
            }
        }
        return true;
    }
}