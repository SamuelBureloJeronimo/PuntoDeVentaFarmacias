namespace PVF.Models
{
    public class PeopleModel
    {
        /*
            * - RFC // Registro Federal del Contribuyente
            * - nmbr // Nombre
            * - apPat // Apellido Paterno
            * - apMat // Apellido Materno
            * - fchNc // Fecha de Nacimiento
            * - estCivil // Estado civil
            * - calle // Numero de la calle
            * - CP // Codigo Postal
            * - telf // Telefono
            * - crr // Correo electronico
            */
        public string RFC { get; set; }
        public string nmbrP { get; set; }
        public string apPat { get; set; }
        public string apMat { get; set; }
        public string fchNc { get; set; }
        public string crr { get; set; }
        public string estCivil { get; set; }
        public int calle { get; set; }
        public int CP { get; set; }
        public int telf { get; set; }
    }
}
