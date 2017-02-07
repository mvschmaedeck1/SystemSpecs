using System.Collections.Generic;
using System.IO;
using System.Linq;
using SystemSpecs.Core.Interface;

namespace SystemSpecs.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T>
    {
        private readonly string TemporaryPath = Path.Combine(Path.GetTempPath(), "SystemSpecs");

        protected List<T> _EntityList;

        public static IEnumerable<string> DefaultDisplayedProperties { get; protected set; }
        public static IEnumerable<string> UserDisplayedProperties { get; protected set; }

        protected BaseRepository()
        {
            _EntityList = new List<T>();

            InitializeEntities();
        }

        protected abstract void InitializeEntities();
        protected abstract void InitializaDisplayedProperties();

        public T Get(int index)
        {
            return _EntityList[index];
        }

        public IEnumerable<T> GetAll()
        {
            return _EntityList.AsEnumerable();
        }

        public void SaveUserDisplayedProperties(string filename)
        {
            filename = Path.Combine(TemporaryPath, string.Format("{0}.prop.config", filename));

            if (!Directory.Exists(TemporaryPath))
            {
                Directory.CreateDirectory(TemporaryPath);
            }

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach(string s in UserDisplayedProperties)
                {
                    writer.WriteLine(s);
                }
            }
        }

        public void LoadUserDisplayedProperties(string filename)
        {
            filename = Path.Combine(TemporaryPath, string.Format("{0}.prop.config", filename));

            if (!Directory.Exists(TemporaryPath))
            {
                Directory.CreateDirectory(TemporaryPath);
            }

            if (!File.Exists(filename))
            {
                CreateUserDisplayedProperties(filename);
            }

            using (StreamReader writer = new StreamReader(filename))
            {
                string line;
                var list = new List<string>();

                while((line = writer.ReadLine()) != null)
                {
                    list.Add(line);
                }

                UserDisplayedProperties = list;
            }
        }

        private void CreateUserDisplayedProperties(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string s in DefaultDisplayedProperties)
                {
                    writer.WriteLine(s);
                }
            }
        }
    }
}