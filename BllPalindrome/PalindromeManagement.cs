using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                string pLine; //Déclarer une nouvelle variable
                string[] tableau; //Créer un tableau pour séparer les résultats en cellules
                pLine = line.Replace(" ", ""); //Effacer tous les espaces
                tableau = pLine.Split(',','(');// Sépare chaque "chose" à chaque ', '. Ca les met dans une nouvelle
                                           // cellule à chaque ','
                cleanList.Add(tableau[0]);// On utilise uniquement la 1ere cellule et on le met dans le nouveau 
                                           // tableau qu'on a crée avant le foreach
                
            }
            return cleanList; // On retourne la ligne nettoyée
        }
    }
}
