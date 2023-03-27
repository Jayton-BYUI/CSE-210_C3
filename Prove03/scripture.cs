// Jayton Crockett and Michael Torres
// Pulls the scripture from the string of text and formats it
public class Scripture
{
    private string _scripture;
    public Scripture(string reference)
    {
        // Opens the csv file
        using (StreamReader sr = new StreamReader("lds-scriptures-csv"))
        {
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                // Breaks the csv file into sections
                string[] fields = line.Split(',');

                // Finds the scripture reference
                if (fields[0] == reference)
                {
                    // Setting the scripture _scripture to be used
                    _scripture = fields[1];
                    break;
                }
            }
        }
    }

    public void Display()
    {
    
    }

    public string scriptureString()
    {
        return _scripture;
    }
}