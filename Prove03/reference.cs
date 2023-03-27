// Jayton Crockett and Michael Torres
// Finds and sets the string of text that is the scripture
public class Reference{
    string jc_reference = "";
    string mt_book = "";
    string jc_verses = "";
    int mt_chapter = 0;
    int jc_singleVerse = 0;

    public void jc_script_ref(string input){
        // Manages the scripture and everything other then words
        int space = input.IndexOf(" ");
        int colon = input.IndexOf(":");
        int dash = input.IndexOf("-");
        int count = 0;

        while(count < space){
            mt_book += input[count];
        }
        jc_reference += mt_book;
        count = space + 1;

        string chapterString = "";
        while (count < colon){
            chapterString += input[count];
        }
        mt_chapter = int.Parse(chapterString);
        jc_reference += mt_chapter;

        count = colon + 1;
        if(dash != -1){
            while (count < input.Length){
                jc_verses += input[count];
            }
            jc_reference += jc_verses;
        }
        else{
            while (count < input.Length){
                jc_verses += input[count];
            }
            jc_singleVerse = int.Parse(jc_verses);
            jc_reference += jc_singleVerse;
        }
    }

    public string getBook(){
    //returns the book name
        return mt_book;
    }

    public int getChapter(){
    //returns the chapter number
        return mt_chapter;
    }

    public int getSingleVerse(){
    //returns verse if its a single verse
        return jc_singleVerse;
    }

    public string getVerses(){
    //returns verses if its multiple verses
        return jc_verses;
    }

    public string getReference(){
    //returns the whole reference
        return jc_reference;
    }
}