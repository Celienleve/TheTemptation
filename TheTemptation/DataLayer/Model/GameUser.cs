using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class GameUser
    {
        [Key]
        public string CodeShortGui { get; set; }
        public string GamePlaying { get; set; }

        //Navigation properties
        public int IdDraw{ get; set; }
        public Draw Draw { get; set; }
    }
}
