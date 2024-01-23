namespace Snake
{
    public enum GridValue
    {
        Empty,     // Cellule vide (pas occupée par le serpent ou de la nourriture)
        Snake,     // Cellule occupée par le corps du serpent
        Food,      // Cellule contenant de la nourriture pour le serpent
        Outside    // Cellule située à l'extérieur de la grille
    }
}