using CoreProject.DataModel;
using CoreProject.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace CoreProject
{
    public class DbEntitys : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    string conString = "";
        //    builder.UseMySql(conString, new MySqlServerVersion(new Version()));
        //}

        public DbEntitys(DbContextOptions<DbEntitys> options) : base(options)
        {

        }
        #region 表映射
        public virtual DbSet<ShipInfo> Ships { get; set; }
        public virtual DbSet<MeasureData> MeasureDatas { get; set; }
        public virtual DbSet<LubeInfo> LubeInfos { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ShipInfoConfiguration());
            modelBuilder.ApplyConfiguration(new MeasureDataConfiguration());
            modelBuilder.ApplyConfiguration(new LubeInfoConfiguration());
        }

    }
}
