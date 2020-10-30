using System;
using SQLite;

namespace TrainingTicket
{
    public class Atividade
    {
        [PrimaryKey, AutoIncrement]
        public uint ID { get; set; }
        public String Nome { get; set; }
        public String Data { get; set; }
    }
}
