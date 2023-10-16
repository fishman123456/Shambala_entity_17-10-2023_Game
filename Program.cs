namespace _Shambala_entity_17_10_2023_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1. вывод всех записей
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    foreach (Game game in db.Games)
                    {
                        Console.WriteLine(game);
                    }
                }

                //// 2. добавить запись
                //using (ApplicationDbContext db = new ApplicationDbContext())
                //{
                //    // 1) сформировать объект
                //    Game game = new Game() { Name = "NewGame", ReleasedIn = 2010, Price = 500 };
                //    // 2) добавить в коллекцию DbSet
                //    db.Games.Add(game);
                //    // 3) зафиксировать изменения
                //    db.SaveChanges();
                //}

                // 3. получить запись по id
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    Game? game = db.Games.FirstOrDefault(game => game.Id == 5);
                    if (game != null)
                    {
                        Console.WriteLine($"found: {game}");
                    }
                    else
                    {
                        Console.WriteLine("not found");
                    }
                }

                //// 4. удаление по id
                //using (ApplicationDbContext db = new ApplicationDbContext())
                //{
                //    Game? game = db.Games.FirstOrDefault(game => game.Id == 48);
                //    if (game != null)
                //    {
                //        db.Games.Remove(game);
                //        db.SaveChanges();
                //    }
                //}

                // 5. обновление по id
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    Game? game = db.Games.FirstOrDefault(game => game.Id == 4);
                    if (game != null)
                    {
                        game.Price *= 2;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something wrong: {ex.Message}");
            }
        }
    }
}