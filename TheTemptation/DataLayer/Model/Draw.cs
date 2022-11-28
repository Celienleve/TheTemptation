using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Draw
    {
        [Key]
        public int IdDraw { get; set; }
        public string GameWin { get; set; }
        public int Jackpot { get; set; }
        public DateTime DateHourDraw { get; set; }

        //Navigation properties // ? = Nullable // Un tirage peut avoir plusieur jeux
        public List<GameUser>? GameUsers { get; set; }
    }
}
