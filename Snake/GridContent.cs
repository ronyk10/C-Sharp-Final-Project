namespace Snake
{
    public enum GridContent
    {
        Empty = 0,    // Cellule vide
        Snake = 1,    // Cellule occupée par le serpent
        Food = 2,     // Cellule contenant de la nourriture
        Outside = 3   // Cellule située à l'extérieur de la grille
    }
}