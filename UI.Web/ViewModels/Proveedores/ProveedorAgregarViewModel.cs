﻿using Foolproof;
using Modelos;
using System.ComponentModel.DataAnnotations;

namespace UI.Web.ViewModels.Proveedores

{
    public class ProveedorAgregarViewModel
    {
        [Display(Name = "Razón Social")]
        [Required(ErrorMessage = "Razón Social es Requerido")]
        public string RazonSocial { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Apellido es Requerido")]
        public string Apellido { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Nombre es Requerido")]
        public string Nombre { get; set; }

        [Display(Name = "DNI")]
        //[Required(ErrorMessage = "DNI es Requerido")]
        public string DNI { get; set; }

        [Display(Name = "Calle")]
        //[RequiredIfNotEmpty("Numero", ErrorMessage = "Calle es Requerido si Número no está vacío")]
        public string Calle { get; set; }

        [Display(Name = "Número")]
        //[RequiredIfNotEmpty("Calle", ErrorMessage = "Número es Requerido si Calle no está vacío")]
        public string Numero { get; set; }

        public bool Bis { get; set; }

        public string Piso { get; set; }

        public string Dpto { get; set; }

        public string Referencia { get; set; }

        [Display(Name = "Teléfono")]
        //[Required(ErrorMessage = "Teléfono es Requerido")]
        public string Telefono { get; set; }

        //[EmailAddress(ErrorMessage = "Email debe ser una dirección de corre electrónico válida")]
        public string Email { get; set; }

        public Proveedor Mapear()
        {
            Proveedor Proveedor = new Proveedor();

            Proveedor.RazonSocial = RazonSocial;
            Proveedor.Apellido = Apellido;
            Proveedor.Nombre = Nombre;
            Proveedor.DNI = DNI;
            Proveedor.Calle = Calle;
            Proveedor.Numero = Numero;
            Proveedor.Bis = Bis;
            Proveedor.Piso = Piso;
            Proveedor.Dpto = Dpto;
            Proveedor.Telefono = Telefono;
            Proveedor.Email = Email;
            Proveedor.Habilitado = true;
            Proveedor.Referencia = Referencia;

            return Proveedor;
        }
    }
}