﻿using Bagy_Yazilim.Data;

namespace Bagy_Yazilim.Helpers;
public class DataHelper
    {
        private static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RestaurantData.json";
        public static void Save(EnvanterContext context)
        {
            FileStream fs = new(Path, FileMode.OpenOrCreate);
            StreamWriter sw = new(fs);
            //sw.Write(JsonConvert.SerializeObject(context, new JsonSerializerSettings()
            //{
            //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            //}));
            fs.Close();
            fs.Dispose();
        }
        public static EnvanterContext Load()

        {
            FileStream fs = new(Path, FileMode.OpenOrCreate);
            StreamReader sr = new(fs);
            string data = sr.ReadToEnd();
            //if (!string.IsNullOrEmpty(data))
            //{
            //    return JsonConvert.DeserializeObject<EnvanterContext>(data);
            //}
            fs.Close();
            fs.Dispose();
            return null;


        }
    }


