using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.common
{
    public class DBConfig
    {
        private static IDictionary<string, string> dbConfig = new Dictionary<string, string>();

        public static void Add(string key, string value)
        {
            dbConfig.Add(key, value);
        }

        public static string get(string key)
        {
            return dbConfig[key];
        }

        public static void Remove(string key)
        {
            dbConfig.Remove(key);
        }

        public static void RemoveAll()
        {
            dbConfig.Clear();
        }

        public const string CreateNewDBPath = "CreateNewDBPath";
        public const string SrcDbTemplatePath = "SrcDbTemplatePath";

        public static void RemoveCreateNewDbFlag()
        {
            dbConfig.Remove(CreateNewDBPath);
            dbConfig.Remove(SrcDbTemplatePath);
        }

        public static void AddCreateNewDbFlag(string CreateNewDBPath, string SrcDbTemplatePath)
        {
            RemoveCreateNewDbFlag();
            dbConfig.Add(CreateNewDBPath, CreateNewDBPath);
            dbConfig.Add(SrcDbTemplatePath, SrcDbTemplatePath);
        }

        public static void CopyNewDbFromTemplate()
        {
            System.IO.File.Copy(dbConfig[CreateNewDBPath], dbConfig[SrcDbTemplatePath]);
        }
    }
}
