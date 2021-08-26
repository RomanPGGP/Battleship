namespace WebApplication1.Models
{
    public class Ship
    {
        public bool status;
        public int row;
        public int col;

        public Ship()
        {
            status = true;
            row = 0;
            col = 0;
        }

        public Ship(int prow, int pcol)
        {
            status = true;
            row = prow;
            col = pcol;
        }
    }
}