namespace DataAccess
{
    public class DbInitialize
    {
        public static void InitData(TravelersDbContext dbContext)
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }
        
    }
}