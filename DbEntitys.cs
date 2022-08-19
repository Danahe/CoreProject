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
        public virtual DbSet<LubeInfo> LubeInfos { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<FileData> FileDatas { get; set; }
        #endregion

        #region 自定义表里的字段名称，无需根据code First模式
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ShipInfoConfiguration());
            modelBuilder.ApplyConfiguration(new LubeInfoConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FileDataConfiguration());
        }

        #endregion


    }
}
