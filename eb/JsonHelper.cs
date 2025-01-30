using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using eb;
using Newtonsoft.Json;


public static class JsonHelper
{
    private static string filePath = "books.json";

    public static void SaveBooksToJson(List<BookDetails> books)
    {
        string filePath = "books.json";

        // Load existing books first to avoid overwriting
        List<BookDetails> existingBooks = LoadBooksFromJson();

        // Add new books to the list
        existingBooks.AddRange(books);

        // Save the updated list
        string json = JsonConvert.SerializeObject(existingBooks, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }


    //public static List<BookDetails> LoadBooksFromJson()
    //{
    //    try
    //    {
    //        if (File.Exists(filePath))
    //        {
    //            string jsonString = File.ReadAllText(filePath);
    //            return System.Text.Json.JsonSerializer.Deserialize<List<BookDetails>>(jsonString) ?? new List<BookDetails>();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }

    //    return new List<BookDetails>();
    //}
    public static List<BookDetails> LoadBooksFromJson()
    {
        string filePath = "books.json";

        if (!File.Exists(filePath))
        {
            return new List<BookDetails>(); // ✅ Return empty list if file doesn't exist
        }

        string json = File.ReadAllText(filePath);
        Console.WriteLine("JSON Loaded: " + json); // ✅ Debug output

        return JsonConvert.DeserializeObject<List<BookDetails>>(json);
    }


}
