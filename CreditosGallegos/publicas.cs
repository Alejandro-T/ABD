using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditosGallegos
{
    class publicas
    {
        public static int _id_tec;
        public static int _id_genero;
        public static int _id_alumno;
        public static int _id_carrera;
        public static int _id_departamento;
        public static int _id_entrenador;
        public static int _id_equipo;
        public static int _id_Ag_equipo;
        public static int _id_Arm_equipo;
        public static string _id_Parti;
        public publicas()
        {
            id_tec = 0;
            id_genero = 0;
            id_alumno = 0;
            id_carrera = 0;
            id_departamento = 0;
            id_entrenador = 0;
            id_equipo = 0;
            id_Ag_equipo = 0;
            id_Arm_equipo = 0;
            id_Parti = "";
        }
        
        public static int id_tec
        {
            get => _id_tec;
            set => _id_tec = value;
        }
        public static int id_genero
        {
            get => _id_genero;
            set => _id_genero = value;
        }
        public static int id_alumno
        {
            get => _id_alumno;
            set => _id_alumno = value;
        }
        public static int id_carrera
        {
            get => _id_carrera;
            set => _id_carrera = value;
        }
        public static int id_departamento
        {
            get => _id_departamento;
            set => _id_departamento = value;
        }
        public static int id_entrenador
        {
            get => _id_entrenador;
            set => _id_entrenador = value;
        }
        public static int id_equipo
        {
            get => _id_equipo;
            set => _id_equipo = value;
        }
        public static int id_Ag_equipo
        {
            get => _id_Ag_equipo;
            set => _id_Ag_equipo = value;
        }
        public static int id_Arm_equipo
        {
            get => _id_Arm_equipo;
            set => _id_Arm_equipo = value;
        }
        public static string id_Parti
        {
            get => _id_Parti;
            set => _id_Parti = value;
        }
        
    }
}
