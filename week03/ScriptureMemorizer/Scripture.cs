using System.Xml.Serialization;

public class Scripture {

   private Reference _reference;
   private List<Word> _words;

   public Scripture(Reference reference, string text) {
      _reference = reference;
      _words = [];
      foreach (string word in text.Split(" ")) {
         Word wordClass = new Word(word);
         _words.Add(wordClass);
      }
   }

   public void HideRandomWords(int numberToHide) {
      Random random = new Random();
      int hiddenWords = 0;
      while (hiddenWords != numberToHide) {
         int index = random.Next(_words.Count());
         if (_words[index].IsHidden() == false) {
            _words[index].Hide();
            hiddenWords += 1;
         }
      }
   }
   public string GetDisplayText() {
      string text = "";
      string underLines = "";
      foreach (Word word in _words) {
         underLines = "";
         if (word.IsHidden()) {
            for (int i = 0; i<word.GetDisplayText().Count(); i++) {
               underLines += "_"; 
            }
            text += underLines + " ";
         }
         else {
            text += word.GetDisplayText() + " ";
         }
      }
      return text;
   }
   public bool IsCompletelyHidden() {
      foreach (Word word in _words) {
         if (!word.IsHidden()) {
            return false;
         }
      }
      return true;
   }
   public void ShowAll() {
      foreach (Word word in _words) {
         word.Show();
      }
   }
}