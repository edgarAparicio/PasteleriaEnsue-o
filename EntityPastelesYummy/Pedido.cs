using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EdgarAparicio.PastelesYummy.Business.Entity
{
    public class Pedido
    {
        [BindNever]
        public int PedidoId { get; set; }

        public List<DetallePedido> DetallePedido { get; set; }

        [Required(ErrorMessage = "Por favor ingresa tu primer nombre")]
        [Display(Name = "Primer Nombre")]
        [StringLength(50)]
        public string PrimerNombre { get; set; }

        [Required(ErrorMessage = "Por favor ingresa tu apellido")]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Por favor ingresa tu direccion")]
        [Display(Name = "Direccion 1")]
        [StringLength(100)]
        public string Direccion1 { get; set; }

        [Display(Name = "Direccion 2")]
        public string Direccion2 { get; set; }

        [Required(ErrorMessage = "Por favor ingresa tu Codigo Postal")]
        [Display(Name = "Codigo postal")]
        [StringLength(10, MinimumLength = 4)]
        public string CodigoPostal { get; set; }

        [Required(ErrorMessage = "Por favor ingresa tu ciudad"), StringLength(50)]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "Por favor ingresa tu estado"), StringLength(50)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Por favor ingresa tu pais"), StringLength(50)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Por favor ingresa tu numero de celular")]
        [Display(Name = "Numero de celular")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string NumeroCelular { get; set; }

        [Required(ErrorMessage = "Por favor ingresa tu email")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "la direccion de email es incorrecta")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal PedidoTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime PedidoEntregado { get; set; }

    }
}
