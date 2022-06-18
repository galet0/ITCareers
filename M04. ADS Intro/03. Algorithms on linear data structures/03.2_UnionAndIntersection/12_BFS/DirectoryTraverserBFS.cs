using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_BFS
{
    public static class DirectoryTraverserBFS
    {
        /// <summary>
        /// Traverses and prints given directory with BFS
        /// </summary>
        /// <param name="directoryPath">the path to the directory             
        /// /// which should be traversed</param>

        public static void TraverseDir(string directoryPath)
        {

            Queue<DirectoryInfo> visitedDirsQueue = new Queue<DirectoryInfo>();

            visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));

            while (visitedDirsQueue.Count > 0)
            {
                DirectoryInfo currentDir = visitedDirsQueue.Dequeue();

                Console.WriteLine(currentDir.FullName);

                DirectoryInfo[] children = currentDir.GetDirectories();

                foreach (DirectoryInfo child in children)
                {
                    visitedDirsQueue.Enqueue(child);
                }

            }

        }
    }
}
