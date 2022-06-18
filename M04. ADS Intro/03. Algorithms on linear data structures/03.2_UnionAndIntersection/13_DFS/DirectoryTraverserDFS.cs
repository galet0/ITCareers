using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DFS
{
    public static class DirectoryTraverserDFS
    {
        /// <summary>
        /// Traverses and prints given directory recursively
        /// </summary>
        /// <param name="dir">the directory to be traversed</param>
        /// <param name="spaces">the spaces used for representation
        /// of the parent-child relation</param>
        private static void TraverseDir(DirectoryInfo dir,string spaces)
        {
            // Visit the current directory
            Console.WriteLine(spaces + dir.FullName);

            DirectoryInfo[] children = dir.GetDirectories();

            // For each child go and visit its subtree
            foreach (DirectoryInfo child in children)
            {
                TraverseDir(child, spaces + "  ");
            }

        }

        /// <summary>
        /// Traverses and prints given directory recursively
        /// </summary>
        /// <param name="directoryPath">the path to the directory
        /// which should be traversed</param>
        public static void TraverseDir(string directoryPath)
        {
            TraverseDir(new DirectoryInfo(directoryPath),string.Empty);
        }

    }
}
