using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using eb;


public static class JsonHelper
{
    private static string filePath = "books.json";

    public static void SaveBooksToJson(List<BookDetails> allbookinfos)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(allbookinfos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static List<BookDetails> LoadBooksFromJson()
    {
        try
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<BookDetails>>(jsonString) ?? new List<BookDetails>();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return new List<BookDetails>();
    }

}
