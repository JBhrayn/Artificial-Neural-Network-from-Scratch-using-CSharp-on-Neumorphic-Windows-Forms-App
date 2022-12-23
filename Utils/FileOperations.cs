using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NN_PROGLAN.ImageProcessing;

namespace NN_PROGLAN.Utils
{
    public static class FileOperations
    {
        public static List<String> GetFiles(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            foreach (var filter in filters)
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));

            return filesFound;
        }

        public static double[] GetVector(string file)
        {
            return new Bitmap(file).CreateMatrix(0.5f).Flatten();
        }

        public static double GetLabel(string file)
        {
            string[] paths = file.Split("\\");
            return Convert.ToDouble(paths[paths.Length - 2]);
        }

        public static string CreateFile(string directory)
        {
            return (Directory.GetFiles(directory, "*", SearchOption.TopDirectoryOnly).Length + 1) + "";
        }

        public static int GetFoldersCount(string datasetFolderPath)
        {
            return new DirectoryInfo(datasetFolderPath).GetDirectories().Length;
        }

        public static void WriteToNotepad(string destination, string text)
        {
            System.IO.File.WriteAllText(destination, text);
        }

    }
}
