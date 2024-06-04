using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CodeFirstApp.Entities;

namespace CodeFirstApp.Configs
{
    public class PrescriptionMedicamentConfiguration : IEntityTypeConfiguration<PrescriptionMedicament>
    {
        public void Configure(EntityTypeBuilder<PrescriptionMedicament> modelBuilder)
        {
            modelBuilder
                .HasKey(pm => new { pm.IdPrescription, pm.IdMedicament });
            modelBuilder
                .HasOne(pm => pm.Prescription)
                .WithMany(p => p.PrescriptionMedicaments)
                .HasForeignKey(pm => pm.IdPrescription);
            modelBuilder
                .HasOne(pm => pm.Medicament)
                .WithMany(m => m.PrescriptionMedicaments)
                .HasForeignKey(pm => pm.IdMedicament);
            modelBuilder
                .ToTable("PrescriptionMedicament");
        }
    }
}