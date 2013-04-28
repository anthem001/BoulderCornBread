﻿using System.Collections.Generic;
using System.Net;

namespace BoulderCornBreadForWindows.RetrieveData
{
    internal class GetWebs
    {

        // retrieve JSON from some url
        private string GetJsonFromUrl(string urlPath)
        {
            var json = new WebClient().DownloadString(urlPath);
            return json;
        }

        // parse out JSON to DataGrid
        public List<JsonData> ParseJson(string url)
        {

            url = "http://getsmartschools.org/currentschools.txt";
            var json = GetJsonFromUrl(url);
            var dataList = new List<JsonData>
                {
                    new JsonData()
                };

            return dataList;
        }
    }

}