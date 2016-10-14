using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrintumWebServices.Areas.Api.Models
{
    public class Product
    {
        public Product()
        {
            grupo = 0;
            codigo = "";
            descripcion = "";
            soporte = "";
            clsinv = "";
        }
        private int grupo;
        private string codigo;
        private string descripcion;
        private string soporte;
        private string clsinv;
        public int Grupo
        {
            set { grupo = value; }
            get { return grupo; }
        }
        public string Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public string Soporte
        {
            set { soporte = value; }
            get { return soporte; }
        }
        public string Clsinv
        {
            set { clsinv = value; }
            get { return clsinv; }
        }
    }
}