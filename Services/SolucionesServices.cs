using AppDalleE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDalleE.Services
{
    public class SolucionesServices
    {
        public static List<Solucion> ObtenerSoluciones()
        {
            List<Solucion> Soluciones = new List<Solucion>()
            {
                new Solucion
                {
                    Nombre = "Parqueaderos",
                    DetallesList = new List<Detalles>
                    {
                        new Detalles
                        {
                            Nombre = "Requisitos",
                            Imagen = "https://images.pexels.com/photos/16603079/pexels-photo-16603079/free-photo-of-ciudad-arte-calle-edificio.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Detalles
                        {
                            Nombre = "Caracteristicas",
                            Imagen = "https://images.pexels.com/photos/16603079/pexels-photo-16603079/free-photo-of-ciudad-arte-calle-edificio.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        }
                    }
                },

                new Solucion
                {
                    Nombre = "Ferreteria",
                    DetallesList = new List<Detalles>
                    {
                        new Detalles
                        {
                            Nombre = "Requisitos",
                            Imagen = "https://images.pexels.com/photos/16603079/pexels-photo-16603079/free-photo-of-ciudad-arte-calle-edificio.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Detalles
                        {
                            Nombre = "Muestras",
                            Imagen = "https://images.pexels.com/photos/16603079/pexels-photo-16603079/free-photo-of-ciudad-arte-calle-edificio.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Detalles
                        {
                            Nombre = "Ejemplos",
                            Imagen = "https://images.pexels.com/photos/16603079/pexels-photo-16603079/free-photo-of-ciudad-arte-calle-edificio.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        }
                    }
                },

                new Solucion
                {
                    Nombre = "Restaurante",
                    DetallesList = new List<Detalles>
                    {
                        new Detalles
                        {
                            Nombre = "Requisitos",
                            Imagen = "https://images.pexels.com/photos/16603079/pexels-photo-16603079/free-photo-of-ciudad-arte-calle-edificio.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Detalles
                        {
                            Nombre = "Muestras",
                            Imagen = "https://images.pexels.com/photos/16603079/pexels-photo-16603079/free-photo-of-ciudad-arte-calle-edificio.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new Detalles
                        {
                            Nombre = "Ejemplos",
                            Imagen = "https://images.pexels.com/photos/16603079/pexels-photo-16603079/free-photo-of-ciudad-arte-calle-edificio.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        }
                    }
                },
            };

            return Soluciones;
        }
    }
}
