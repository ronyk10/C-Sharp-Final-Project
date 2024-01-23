using System;
using System.Collections.Generic;

namespace Snake
{
    public class Position
    {
        // Lecture seule pour la ligne et la colonne de la position
        public int Row { get; }
        public int Col { get; }

        // Initialise une position avec une ligne et une colonne
        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }

        // Traduis la position selon une direction donnée
        public Position Translate(Direction dir)
        {
            return new Position(Row + dir.RowOffset, Col + dir.ColOffset);
        }

        // Compare si deux positions sont égales
        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Col == position.Col;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Col);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }
    }
}