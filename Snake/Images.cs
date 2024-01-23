using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    // Classe statique pour gérer les images utilisées dans le jeu Snake
    public static class Images
    {
        // Image pour une cellule vide
        public readonly static ImageSource Empty = LoadImage("Empty.png");

        // Image pour le corps du serpent
        public readonly static ImageSource Body = LoadImage("Body.png");

        // Image pour la tête du serpent
        public readonly static ImageSource Head = LoadImage("Head.png");

        // Image pour la nourriture du serpent
        public readonly static ImageSource Food = LoadImage("Food.png");

        // Image pour le corps du serpent lorsqu'il est mort
        public readonly static ImageSource DeadBody = LoadImage("DeadBody.png");

        // Image pour la tête du serpent lorsqu'il est mort
        public readonly static ImageSource DeadHead = LoadImage("DeadHead.png");

        // Charge une image à partir d'un fichier
        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
        }
    }
}