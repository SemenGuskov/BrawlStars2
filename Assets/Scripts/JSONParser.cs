using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class JSONParser : MonoBehaviour
{
    public string projectDirectoryPath = "D:\\Clone a repository GitHub\\BrawlStars2";
    void Start()
    {
        string jsonString = "{ \"entries\": [ { \"tag\": \"folder\", \"name\": \"Images\", \"path_lower\": \"/images\", \"path_display\": \"/Images\", \"id\": \"id:I16RdNnlVDsAAAAAAAAACA\" }, { \".tag\": \"file\", \"name\": \"brawler_models.json\", \"path_lower\": \"/brawler_models.json\", \"path_display\": \"/brawler_models.json\", \"id\": \"id:I16RdNnlVDsAAAAAAAAHGg\", \"client_modified\": \"2023-07-20T08:31:38Z\", \"server_modified\": \"2023-07-20T08:31:39Z\", \"rev\": \"01600e6fa1feac30000000106d557f1\", \"size\": 56381, \"is_downloadable\": true, \"content_hash\": \"2b5000263446cd065e1069f1991cc4f539707d3184ff990aca7eb896cba3b1ce\" } ], \"cursor\": \"AAFCmTmHZfDXJoiKf5KqSPXtoHYkaGWLpG0IGNCnG7L1JZOQcUbBz9Mg6yoPJDJuhSz2wvT2BGdwsrxT-m4wU-CyRV8aGyimVXmJsg9KfjLiGg5qoiH6PXn8xCuWOiog_1cfNpDH1HXcrf6u1XnaSNSfD_VCUnwfNaGxV9Mpkwb7XfZ1NRYc48Fo9wilRRNgVZI\", \"has_more\": false }";

        RootObject data = JsonConvert.DeserializeObject<RootObject>(jsonString);

        foreach (Entry entry in data.entries)
        {
            Debug.Log(Directory.GetFiles(entry.ToString()));
            Debug.Log("Name: " + entry.name);
            Debug.Log("Type: " + entry.tag);
            Debug.Log("Path: " + entry.path_display);
            Debug.Log("ID: " + entry.id);

 

            if (entry.path_lower.StartsWith(projectDirectoryPath.ToLower()) || entry.path_display.StartsWith(projectDirectoryPath)) // Проверка на соответствие пути к директории проекта Unity
            {
                Debug.Log("Ресурс находится в директории проекта Unity.");

                if (entry.tag == "file")
                {
                    Debug.Log("Client Modified: " + entry.client_modified);
                    Debug.Log("Server Modified: " + entry.server_modified);
                    Debug.Log("Size: " + entry.size);
                    Debug.Log("Is Downloadable: " + entry.is_downloadable);
                    Debug.Log("Content Hash: " + entry.content_hash);
                }
            }
            else
            {
                Debug.Log("Ресурс НЕ находится в директории проекта Unity.");
            }

        }
    }



    [System.Serializable]
    public class Entry
    {
        public string tag;
        public string name;
        public string path_lower;
        public string path_display;
        public string id;
        public string client_modified;
        public string server_modified;
        public string rev;
        public int size;
        public bool is_downloadable;
        public string content_hash;
    }

    [System.Serializable]
    public class RootObject
    {
        public List<Entry> entries;
        public string cursor;
        public bool has_more;
    }
}
