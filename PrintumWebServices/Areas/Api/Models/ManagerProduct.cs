using PrintumWebServices.Areas.Api.Models.DataSetProductTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrintumWebServices.Areas.Api.Models
{
    public class ManagerProduct
    {
        public  List<Product> values(string a)
        {
            ProductosTableAdapter table = new ProductosTableAdapter();
            List<Product> resultQuery = new List<Product>();
            Product productQuery = new Product();
            try
            {
                foreach (System.Data.DataRow row in table.GetDataBy(a).Rows)
                {
                    // Productos.Grupo, Productos.Código, Productos.Descripción, Productos.sOPORTE, Productos.cLSiNV, Pro_Certificados.[No], Pro_Certificados.cERTIdRIVE

                    int grupo = int.Parse(row["Grupo"].ToString());  
                    productQuery.Grupo = grupo;
                    string codigo = row["Código"].ToString();
                    productQuery.Codigo = codigo;
                    string descrip = row["Descripción"].ToString();
                    productQuery.Descripcion = descrip;
                    string soporte = row["sOPORTE"].ToString();
                    productQuery.Soporte = soporte;
                    string cLSiNV = row["cLSiNV"].ToString();
                    productQuery.Clsinv = cLSiNV;
                    resultQuery.Add(productQuery);
                }
                //"Datas::" + grupo + " " + codigo + " " + descrip + " " + soporte + " " + cLSiNV + " " + NoCer + "" + DriveCer
                return resultQuery;
            }
            catch (Exception ex)
            {
                return resultQuery;
                System.Console.WriteLine("" + ex.GetBaseException());
            }
        }
    }
}