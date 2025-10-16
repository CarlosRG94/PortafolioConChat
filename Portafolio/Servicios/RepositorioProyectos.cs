using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos:IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            var proyectos = new List<Proyecto>()
            {
                new Proyecto(){
                    Titulo="Tour Virtual",
                    Descripcion="Tour virtual 360 realizado en Unity3D durante mis prácticas, permitiendo explorar espacios de manera interactiva.",
                    VideoURL = "https://www.youtube.com/watch?v=cBJWy9AZHY0"
                },
                new Proyecto(){
                    Titulo="Proyecto IA",
                    Descripcion="Análisis de hábitos de compra con machine learning: limpieza de datos, segmentación de clientes (K-Means), reglas de asociación (Apriori), modelos de clasificación y regresión para predicción de gasto. Resultados para decisiones de marketing y fidelización. [Ver más en GitHub]",
                    ImagenURL = "/Imagenes/MatrizConfusion.png",
                    Link="https://github.com/CarlosRG94/Proyecto-IA"
                },
                new Proyecto(){
                    Titulo="Proyecto Presupuestos.Net",
                    Descripcion="Aplicación para registrar y controlar ingresos y gastos de una empresa o persona, facilitando la gestión financiera.",
                    VideoURL = "https://www.youtube.com/watch?v=jvLhu2C9cN4"
                },
                new Proyecto(){
                    Titulo="Proyecto Java",
                    Descripcion="Aplicación para gestionar propiedades de una inmobiliaria, desarrollada en Java durante el curso de DAM.",
                    VideoURL = "https://www.youtube.com/watch?v=YiIuWADuQqI"
                },
                new Proyecto(){
                    Titulo="Proyecto Android",
                    Descripcion="Calculadora móvil realizada con Android Studio, mostrando habilidades en desarrollo de apps Android.",
                    VideoURL = "https://youtu.be/GFdOMs6cHRY"
                },
                new Proyecto(){
                    Titulo="Proyecto Tareas.Net",
                    Descripcion="Aplicación para organizar y gestionar tareas diarias, optimizando la productividad.",
                    VideoURL = "https://www.youtube.com/watch?v=iGWu7iw8fhU"
                }
              };
            return proyectos;
        }
    }
}
