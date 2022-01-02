using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ORM_Core
{
    public class NotesCollection : DbContext
    {                
        public NotesCollection()
        {
            Database.EnsureCreated();

            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var str = GetConnectionString();

            optionsBuilder.UseSqlServer(str);
        }

        private string GetConnectionString()
        {
            string path = Environment.CurrentDirectory + @"\" + @"Config\AppConfig.json";

            FileInfo fs = new FileInfo(path);

            if (fs.Exists)
            {
                string res = File.ReadAllText(path);

                JObject json = JObject.Parse(res);

                return json["ConnectionString"].Value<string>();
            }

            return String.Empty;
        }

        public DbSet<Notes> Notes { get; set; }
    }
}
