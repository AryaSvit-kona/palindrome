using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DalPalindrome;

namespace BllPalindrome
{
    public class PalindromeManagement
    {
        public List<string> GetListPalindromeFromFile(string pFileName)
        {
            FileTextReaderUtility myReader = new FileTextReaderUtility();
            List<string> readLines = myReader.ReadAllLines(pFileName);
            List<string> cleanList = new List<string>(); //Créer une nouvelle liste de string ==> Instancier.Le mettre en mémoire

            foreach (string line in readLines)
            {
                string text = line;                
                text = Regex.Replace(text, @"\(.*\)", "");// Remove text between brackets.
                /*text = Regex.Replace(text, @"\s+", " ");*/                // Remove extra spaces.
                //Console.WriteLine(text);
                //string pLine; //Déclarer une nouvelle variable
                string[] tableau;
                text.Trim();
                //Créer un tableau pour séparer les résultats en cellules
               // pLine = line.Replace(" ", ""); //*
                tableau = text.Split(',');// Sépare chaque "chose" à chaque ', '. Ca les met dans une nouvelle
                                           // cellule à chaque ','
                cleanList.Add(tableau[0].Trim());// On utilise uniquement la 1ere cellule et on le met dans le nouveau 
                                           // tableau qu'on a crée avant le foreach
                
            }
            return cleanList; // On retourne la ligne nettoyée
        }
    }
}
