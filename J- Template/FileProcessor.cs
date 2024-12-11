using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J__Template
{
    internal abstract class FileProcessor
    {
        // Methode Template
        public void ProcessFile(string filePath)
        {
            ReadFile(filePath);
            ProcessData();
            SaveFile();
        }

        // etape commune : lire le fichier
        protected virtual void ReadFile(string filePath)
        {
            Console.WriteLine($"Reading file from {filePath}...");
        }

        // etape specifique : traitement des donnee
        protected abstract void ProcessData();

        // etape commune : sauvegarder le fichier
        protected virtual void SaveFile()
        {
            Console.WriteLine("Saving processed file...");
        }
    }
}
