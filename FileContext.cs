using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HotelRoomManagementProject_LayeredArchitecture
{
    class FileContext
    {
        // This class is responsible for loading and saving data to a JSON file.
        private static string filePath = "Hotel.json"; // Default file path for data storage

        public static List<T> DataLoad<T>(string filePath) // Load method to read data from a JSON file
        {
            if (!File.Exists(filePath)) // Check if the file exists
                return new List<T>(); // If not, return an empty list of type T

            var jsonData = File.ReadAllText(filePath);// Read the content of the file
            return JsonSerializer.Deserialize<List<T>>(jsonData) ?? new List<T>(); // 
        }
        public static void DataSave<T>(List<T> data, string filePath) // Save method to write data to a JSON file
        {
            var jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }); // Serialize the data to JSON format with indentation for readability
            File.WriteAllText(filePath, jsonData); // Write the serialized JSON data to the specified file path
        }
    }
}