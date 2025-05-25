namespace StudentAPI.Models
{
    public class Student
    {
        public int CI { get; set; }           // Cédula de Identidad
        public required string Nombre { get; set; }    // Nombre del estudiante
        public int Nota { get; set; }         // Nota final (de 0 a 100)
    }
}