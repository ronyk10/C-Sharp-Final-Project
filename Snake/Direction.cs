using System;
using System.Collections.Generic;

namespace Snake
{
    // Classe pour la direction dans le jeu 
    public class Direction
    {
        // Définition des directions statiques
        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);

        // Décalage de ligne et de colonne pour la direction
        public int RowOffset { get; }
        public int ColOffset { get; }

        // Constructeur privé pour initialiser les décalages de ligne et de colonne
        private Direction(int rowOffset, int colOffset)
        {
            RowOffset = rowOffset;
            ColOffset = colOffset;
        }

        // Méthode pour obtenir la direction opposée
        public Direction Opposite()
        {
            return new Direction(-RowOffset, -ColOffset);
        }

        // Méthode pour comparer les objets Direction
        public override bool Equals(object obj)
        {
            return obj is Direction direction &&
                   RowOffset == direction.RowOffset &&
                   ColOffset == direction.ColOffset;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RowOffset, ColOffset);
        }

        public static bool operator ==(Direction left, Direction right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator !=(Direction left, Direction right)
        {
            return !(left == right);
        }
    }
}
