using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RetroTime.IO
{
    /// <summary>
    /// 文件处理
    /// </summary>
    public class FILE
    {
        /// <summary>
        /// 创建一个文本文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="content">内容</param>
        public static void Create(string path, string content)
        {
            StreamWriter TextData = new StreamWriter(path);
            TextData.Write(content);
            TextData.Close();
        }
        /// <summary>
        /// 创建一个序列化对象信息的文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="_object">对象</param>
        public static void Create(string path, object _object)
        {
            FileStream Stream = new FileStream(path, FileMode.Create);
            BinaryFormatter PlauerDataBFormatter = new BinaryFormatter();
            PlauerDataBFormatter.Serialize(Stream, _object);
            Stream.Close();
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="path">路径</param>
        public static void Delete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="path">源文件路径</param>
        /// <param name="objectivePath">目标路径</param>
        public static void Move(string path, string objectivePath)
        {
            if (File.Exists(path))
            {
                File.Move(path, objectivePath);
            }
        }
        /// <summary>
        /// 获得当前路径下文件的列表
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns>文件列表</returns>
        public static string[] Get(string path)
        {
            if (Directory.Exists(path))
            {
                string[] list = Directory.GetFiles(path);
                return list;
            }
            else
            {
                return null;
            }

        }
        /// <summary>
        /// 读取文本文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns>内容</returns>
        public static string ReadText(string path)
        {
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                return content;
            }
            else
            {
                return null;
            }

        }
        /// <summary>
        /// 读取对象文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns>内容</returns>
        public static object ReadObject(string path)
        {
            if (File.Exists(path))
            {
                object _Object = null;
                FileStream Stream = new FileStream(path, FileMode.Open);
                BinaryFormatter bFormat = new BinaryFormatter();
                _Object = bFormat.Deserialize(Stream);
                Stream.Close();
                return _Object;
            }
            else
            {
                return null;
            }
        }
    }
    /// <summary>
    /// 路径处理
    /// </summary>
    public class DIR
    {
        /// <summary>
        /// 创建一个路径
        /// </summary>
        /// <param name="path">路径</param>
        public static void Create(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            dir.CreateSubdirectory(path);
        }
        /// <summary>
        /// 删除一个路径
        /// </summary>
        /// <param name="path">路径</param>
        public static void Delete(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
        }
        /// <summary>
        /// 获得当前路径下所有的子目录
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns>路径列表</returns>
        public static string[] Get(string path)
        {
            if (Directory.Exists(path))
            {
                string[] list = Directory.GetDirectories(path);
                return list;
            }
            else
            {
                return null;
            }
        }
    }
}
