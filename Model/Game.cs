using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Shambala_entity_17_10_2023_Game
{
    //https://codeshare.io/wnrVyj - здесь код передаем, как в блокноте
    // Класс-сущность, в которую отображается таблица game_t
    [Table("game_t")]
    internal class Game
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name_f")]
        public string Name { get; set; }

        [Column("released_in_f")]
        public int ReleasedIn { get; set; }

        [Column("price_f")]
        public int Price { get; set; }

        public Game()
        {
            Id = 0;
            Name = "";
            ReleasedIn = 0;
            Price = 0;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {ReleasedIn} - {Price}";
        }
    }
}
