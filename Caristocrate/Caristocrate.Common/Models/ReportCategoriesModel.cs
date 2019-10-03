﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Caristocrate.Common.Models
{
    public class ReportCategoriesModel
    {
        public class Data
        {
            public int id { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public object deleted_at { get; set; }
            public string title { get; set; }
        }

        public class Response
        {
            public bool success { get; set; }
            public List<Data> data { get; set; }
            public string message { get; set; }
            public int total_count { get; set; }
        }
    }

    public class CarReportModel
    {

        public class Data
        {
            public int car_id { get; set; }
            public int report_category_id { get; set; }
            public string message { get; set; }
            public int user_id { get; set; }
            public string updated_at { get; set; }
            public string created_at { get; set; }
            public int id { get; set; }
        }

        public class Response
        {
            public bool success { get; set; }
            public Data data { get; set; }
            public string message { get; set; }
            public int total_count { get; set; }
        }

        public class Request
        {
            public int car_id { get; set; }
            public int report_category_id { get; set; }
            public string message { get; set; }
        }
    }
}