using System;
namespace Tarea_7.Data
{
    public class Persona
    {
        private string _apellidos;
        private DateTime _nacimiento;

        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos
        {
            get
            {
                if (string.IsNullOrEmpty(_apellidos))
                    return Apellido1 + " " + Apellido2;
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento
        {
            get
            {
                return FechaNacimiento;
            }

            set
            {
                _nacimiento = TransformarIsoAFecha(value);
            }
        }
        public DateTime Nacimiento
        {
            get
            {
                return _nacimiento;
            }

            set
            {
                _nacimiento = value;
            }
        }
        public DateTime PrimeraDosis { get; set; }
        public DateTime SegundaDosis { get; set; }
        public string LugarNacimiento { get; set; }
        public string Provincia { get; set; }
        public string VacunaRecibida { get; set; }

        private DateTime TransformarIsoAFecha(string fecha)
        {
            string format = "yyyy-MM-dd hh:mm:ss.fff";
            return DateTime.ParseExact(fecha, format, System.Globalization.CultureInfo.InvariantCulture);
        }

    }
}