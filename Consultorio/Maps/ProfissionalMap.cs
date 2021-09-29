using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Consultorio.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Maps
{
    public class ProfissionalMap : BaseMap<Profissional>
    {
        public ProfissionalMap() : base ("tb_profissional")
        {}

        public override void Configure(EntityTypeBuilder<Profissional> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo");

            builder.HasMany(x => x.Especialidades)
                .WithMany(x => x.Profissionais)
                .UsingEntity<ProfissionalEspecialidade>(
                    x => x.HasOne(p => p.Especialidade).WithMany().HasForeignKey(x => x.EspecialidadeId),
                    x => x.HasOne(p => p.Profissionais).WithMany().HasForeignKey(x => x.ProfissionalId),
                    x =>
                    {
                        x.ToTable("tb_profissional_especialidade");

                        x.HasKey(p => new { p.EspecialidadeId, p.ProfissionalId });

                        x.Property(p => p.EspecialidadeId).HasColumnName("id_especialidade").IsRequired();
                        x.Property(p => p.ProfissionalId).HasColumnName("id_profissional").IsRequired();
                    }
                ); ;
        }
    }
}
