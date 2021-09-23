using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjectLayer
{
    public class PhoneBookDOL
    {
   public const string Select = @"SELECT PhoneBook.PhoneBookID, PhoneBook.Name1, PhoneBook.Address1, PhoneBook.Name2, Subject.SubjectTitle, PhoneBook.Address2,   PhoneBook.Fax1, PhoneBook.Fax2, PhoneBook.Tel1, PhoneBook.Tel2, PhoneBook.Mobile1, PhoneBook.Mobile2, PhoneBook.SubjectID,   PhoneBook.Email, PhoneBook.CityID, City.CityTitle FROM    PhoneBook LEFT OUTER JOIN  City ON PhoneBook.CityID = City.CityID LEFT OUTER JOIN  Subject ON PhoneBook.SubjectID = Subject.SubjectID";
   public const string Insert = @"INSERT INTO PhoneBook( Name1, Name2, Address1, Address2, Fax1, Fax2, Tel1, Tel2, Mobile1, Mobile2, SubjectID, Email, CityID) VALUES(@Name1, @Name2, @Address1, @Address2, @Fax1, @Fax2, @Tel1, @Tel2, @Mobile1, @Mobile2, @SubjectID, @Email, @CityID)";   
   public const string Delete = "DELETE FROM PHONEBOOK WHERE PHONEBOOKID = @PhoneBookId";
   public const string Update = "UPDATE PhoneBook SET Name1 = @Name1, Name2 = @Name2, Address1 = @Address1, Address2 = @Address2, Fax1 = @Fax1, Fax2 = @Fax2, Tel1 = @Tel1, Tel2 = @Tel2, Mobile1 = @Mobile1, Mobile2 = @Mobile2, SubjectID = @SubjectID, Email = @Email, CityID = @CityID WHERE PHONEBOOKID = @PhoneBookId";
   public const string SelectMaxId = "SELECT ISNULL(MAX(PHONEBOOKID),0)+1 AS MAX_PHONEBOOK_ID FROM PHONEBOOK";
   public enum QueryStatus { Select,SelectComboBox, Insert, Delete, Update, SelectMaxId };
    }
}
