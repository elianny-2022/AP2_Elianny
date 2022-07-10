using System.ComponentModel.DataAnnotations;

public class Vitaminas
{
    [Key]
    public int VitaminaId { get; set; }
    public string Descripcion { get; set; }
    public double UnidadDeMedida { get; set; }
    
}