using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CodeFirstApp.Entities;

namespace CodeFirstApp.Configs
{
    public class MedicamentConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> modelBuilder)
        {
            modelBuilder
                .HasKey(m => m.IdMedicament);
            modelBuilder
                .Property(m => m.IdMedicament)
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder
                .Property(m => m.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder
                .Property(m => m.Description)
                .HasMaxLength(1000);
            modelBuilder
                .Property(m => m.Type)
                .IsRequired();
            modelBuilder
                .ToTable("Medicament");
        }
    }
}