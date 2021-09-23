using System;

namespace BusinessObjectLayer
{
    public class ExceptionHandlerBOL
    {
        private string title;
        private string keyValues;
        private string description;
        private string helpNote;
        private string originalMessage;

        public string Title
        {
            get
            {
                return this.title;
            }
        }
        public string KeyValues 
        { 
            get
            {
                return this.keyValues; 
            } 
        }
        public string Description 
        {
            get 
            {
                return this.description; 
            } 
        }
        public string HelpNote 
        {
            get
            {
                return this.helpNote;
            }
        }
        public string OriginalMessage
        {
            get 
            {
                return this.originalMessage;
            } 
        }
        public ExceptionHandlerBOL(string Title, string KeyValues, string Description, string HelpNote, string OriginalMessage)
        {
            this.title = Title;
            this.keyValues = KeyValues;
            this.description = Description;
            this.helpNote = HelpNote;
            this.originalMessage = OriginalMessage;
        }
    }
}