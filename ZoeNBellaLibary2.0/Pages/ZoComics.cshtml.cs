using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace ZoeNBellaLibary2._0.Pages
{
    //This is the page that will display the comics that zoe recommends
    public class ZoComicsModel : PageModel
    {
        //this how they will select what comic they want my recommended
        [BindProperty]
        public int SelectedComicId { get; set; }
        //This is the dropdown list that will hold the comics
        public List<SelectListItem> ComicList { get; set; }
        //Property to hold the selected comic details
        public Comic SelectedComic { get; set; }
        //Handles the http request to the pages & loads the comics into the dropdown list
        public void OnGet()
        {
            LoadComicList();
        }
        //handles ttp post request 
        //also retrieves the selected comics details 
        public IActionResult OnPost()
        {
            LoadComicList();
            if (SelectedComicId != 0)
            {
                SelectedComic = GetComicById(SelectedComicId);
            }
            return Page();
        }
        //helper method that loads the list of comics from Sqlite datbase
        //for diaplying the dropdown menu
        private void LoadComicList()
        {
            ComicList = new List<SelectListItem>();
            using (var connection = new SqliteConnection("Data Source=ZoesComics.db"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Comics_ID, Comic_Name FROM Comics";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ComicList.Add(new SelectListItem
                        {
                            Value = reader.GetInt32(0).ToString(),
                            Text = reader.GetString(1)
                        });
                    }
                }
            }
        }
        //helper method that reretrieves the details of the selected comic from the database
        //returns a Comic details 
        private Comic GetComicById(int id)
        {
            using (var connection = new SqliteConnection("Data Source=ZoesComics.db"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Comics WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Comic
                        {
                            Comics_ID = reader.GetInt32(0),
                            Comic_Name = reader.GetString(1),
                            Comic_Description = reader.GetString(2),
                            Personal_thoughts = reader.GetString(5),
                            Comic_Price = reader.GetDecimal(3),
                            ImageFileName = reader.GetString(4)
                        };
                    }
                }
            }
            return null;
        }
        public class Comic
        {
            public int Comics_ID { get; set; }
            public string Comic_Name { get; set; }
            public string Comic_Description { get; set; }
            public string Personal_thoughts { get; set; }
            public decimal Comic_Price { get; set; }
            public string ImageFileName { get; set; }
        }

    }
}