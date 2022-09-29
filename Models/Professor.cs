namespace lab3.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Genero { get; set; }
        public string Materia { get; set; }
        private List<Professor> listaProfessor { get; set; }


        public void CriarProfessor()
        {
            listaProfessor = new List<Professor>()
            {
                new Professor(){ Id = 1,Nome= "Antônio Bandeiras",Idade=53, Genero = 'O', Materia="Espanhol"},
                new Professor(){ Id = 2,Nome= "Benedito Valadares",Idade=73, Genero = 'M', Materia="Biologia Aplicada"},
                new Professor(){ Id = 3,Nome= "Maria das Dores",Idade=67, Genero = 'F', Materia="Lança Perfume II"},
                new Professor(){ Id = 4,Nome= "Lucimar Palhares",Idade=59, Genero = 'M', Materia="Redação"},
                new Professor(){ Id = 5,Nome= "Gilberto Agrião",Idade=42, Genero = 'D', Materia="Filosofia"},
                new Professor(){ Id = 6,Nome= "João Roberto",Idade=38, Genero = 'M', Materia="Gude I"}
            };
        }

        public List<Professor> BuscarProfessor()
        {
            return listaProfessor;
        }
    }
}