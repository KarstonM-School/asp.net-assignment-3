namespace asp.net_assignment_3.Models
{
    public class BorrowingRepo
    {
        private static List<Borrowing> _borrowings = new List<Borrowing>()
        {
            new Borrowing{Id = 1, BookId = 200, BorrowerId = 55, IsReturned = false},
            new Borrowing{Id = 2, BookId = 100, BorrowerId = 2, IsReturned = true},
            new Borrowing{Id = 3, BookId = 2, BorrowerId = 3, IsReturned = false}
        };

        public static List<Borrowing> GetBorrowingList() { return _borrowings; }

        public static Borrowing? GetBorrowingById(int borrowingId)
        {
            var borrowing = _borrowings.FirstOrDefault(b => b.Id == borrowingId);
            if (borrowing != null)
            {
                return borrowing;
            }
            return null;
        }

        public static void AddBorrowing(Borrowing borrowing)
        {
            var maxId = _borrowings.Count;
            borrowing.Id = maxId + 1;
            _borrowings.Add(borrowing);
        }

        public static void UpdateBorrowing(Borrowing borrowing)
        {
            var borrowingToUpdate = _borrowings.FirstOrDefault(b => b.Id == borrowing.Id);
            if (borrowingToUpdate != null)
            {
                borrowingToUpdate.BookId = borrowing.BookId;
                borrowingToUpdate.BorrowerId = borrowing.BorrowerId;
                borrowingToUpdate.IsReturned = borrowing.IsReturned;
            }
        }

        public static void DeleteBorrowing(int borrowingId)
        {
            var borrowing = _borrowings.FirstOrDefault(b => b.Id == borrowingId);
            if (borrowing != null)
            {
                _borrowings.Remove(borrowing);
            }
        }
    }
}
