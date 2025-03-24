public class Comment {
   private string _userName;
   private string _comment;

   public Comment(string person, string comment) {
      _userName = person;
      _comment = comment;
   }

   public void SetPerson(string person) {
      _userName = person;
   }

   public string GetUserName() {
      return _userName;
   }

   public void Set(string comment) {
      _comment = comment;
   }

   public string GetComment() {
      return _comment;
   }
}