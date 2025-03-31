namespace asp.net_assignment_3.Models
{
    public class ReaderRepo
    {
        private static List<Reader> _readers = new List<Reader>()
        {
            new Reader{Id = 1, Name = "Karston Matthews", Email = "example@email.com", PhoneNumber = "587-555-4444", Address = "123 Address Ave"},
            new Reader{Id = 2, Name = "Alicia Greene", Email = "alicia.greene@email.com", PhoneNumber = "403-555-1122", Address = "456 Maple Street"},
            new Reader{Id = 3, Name = "Jamal White", Email = "jamal.white@email.com", PhoneNumber = "780-555-3377", Address = "789 Oak Drive"}
        };

        public static List<Reader> GetReaderList() { return _readers; }

        public static Reader? GetReaderById(int readerId)
        {
            var reader = _readers.FirstOrDefault(b => b.Id == readerId);
            if (reader != null)
            {
                return reader;
            }
            return null;
        }

        public static void AddReader(Reader reader)
        {
            var maxId = _readers.Count;
            reader.Id = maxId + 1;
            _readers.Add(reader);
        }

        public static void UpdateReader(Reader reader)
        {
            var readerToUpdate = _readers.FirstOrDefault(b => b.Id == reader.Id);
            if (readerToUpdate != null)
            {
                readerToUpdate.Name = reader.Name;
                readerToUpdate.Email = reader.Email;
                readerToUpdate.PhoneNumber = reader.PhoneNumber;
                readerToUpdate.Address = reader.Address;
            }
        }

        public static void DeleteReader(int readerId)
        {
            var reader = _readers.FirstOrDefault(b => b.Id == readerId);
            if (reader != null)
            {
                _readers.Remove(reader);
            }
        }
    }
}
