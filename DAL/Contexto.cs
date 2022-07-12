using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Verduras> Verduras { get; set; }
    public DbSet<Vitaminas> Vitaminas { get; set; }
     public Contexto(DbContextOptions<Contexto>  options) : base(options)    
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Vitaminas>().HasData(
            new Vitaminas{
                VitaminaId = 1,
                Descripcion="Vitamina C",
                Existencia=0,
                UnidadMedida= "mg"
            },
            new Vitaminas{
                VitaminaId = 2,
                Descripcion="Vitamina E ",
                Existencia =0,
                UnidadMedida= "mg"
            },
            new Vitaminas{
                VitaminaId =3,
                Descripcion ="Vitamina K ",
                Existencia =0,
                UnidadMedida= "mcg"
            },
            new Vitaminas{
                VitaminaId =4,
                Descripcion="Vitamina A ",
                Existencia=0,
                UnidadMedida= "mcg RAE"
            },
            new Vitaminas{
                VitaminaId =5,
                Descripcion="Betaína",
                Existencia = 0,
                UnidadMedida= "mcg RAE"

            }, 
            new Vitaminas{
                VitaminaId = 6,
                Descripcion ="Tiamina(B1)",
                Existencia=0,
                UnidadMedida= "mg"
            },
            new Vitaminas{
                VitaminaId =7,
                Descripcion = "Riboflavina(B2)",
                Existencia = 0,
                UnidadMedida= "mg"
            },
            new Vitaminas{
                VitaminaId =8,
                Descripcion="Ácido fólico(B9)",
                Existencia= 0,
                UnidadMedida= "(mg)"
            },
            new Vitaminas{
                VitaminaId =9,
                Descripcion="Choline",
                Existencia =0,
                UnidadMedida= "(mg)"
            },
            new Vitaminas{
                VitaminaId=10,
                Descripcion="Folate(B9) (μg)",
                Existencia = 0,
                UnidadMedida= "(μg)"
            }
        );

    }
}