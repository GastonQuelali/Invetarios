using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPInventarios.Models;

public class Categoria
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre de la categoría es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre no debe exceder los 50 caracteres.")]
    public string Nombre { get; set; }

    [StringLength(200, ErrorMessage = "La descripción no debe exceder los 200 caracteres.")]
    public string Descripcion { get; set; }

    [Display(Name = "Categoría Padre")]
    public int? CategoriaIdPadre { get; set; }
    
    [ForeignKey("CategoriaIdPadre")]
    public virtual Categoria CategoriaPadre { get; set; }

    public virtual ICollection<Categoria> Subcategorias { get; set; } = new List<Categoria>();
    public virtual ICollection<ProductoCategoria> ProductoCategorias { get; set; } = new List<ProductoCategoria>();
}
