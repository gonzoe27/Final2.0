//This is my C# class for Books. I will store here the information on the books I store 
namespace ZoeNBellaLibary2._0.Models
{
    //The name of the class is Book
    public class Book
    {
        //Each book will get a book Id making it easier to identify rather than name
        public int Book_ID {get; set;}
        //Storing the Book name to later display it to the user
        public string Book_Name {get; set;}
        //Storing a small description of what the book is about
        public string Book_Description {get; set;}
        //Storing The author of the book
        public string Book_Author {get; set;}
        //The original price Bought at 
        public int Bought_Price {get; set;}
        //I want to display a image when view the book 
        public string ImageFileNmae {get; set;}
        //There will also be a rating from 1-10 on how much the book was liked
        public int Rating {get; set;}
    }
}