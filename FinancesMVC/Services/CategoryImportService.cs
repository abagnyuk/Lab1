﻿//using ClosedXML.Excel;
//using FinancesMVC.Models;
//using Microsoft.EntityFrameworkCore;

//namespace FinancesMVC.Services
//{
//    public class CategoryImportService : IImportService<Category>
//    {
//        private readonly Db1Context _context;
//        // реалізація AddMovieAsync та інших методів

//        public CategoryImportService(Db1Context context)
//        {
//            _context = context;
//        }

//        public async Task ImportFromStreamAsync(Stream stream, CancellationToken cancellationToken)
//        {
//            if (!stream.CanRead)
//            {
//                throw new ArgumentException("Дані не можуть бути прочитані", nameof(stream));
//            }

//            using (XLWorkbook workBook = new XLWorkbook(stream))
//            {
//                //перегляд усіх листів (в даному випадку категорій книг)
//                foreach (IXLWorksheet worksheet in workBook.Worksheets)
//                {
//                    //worksheet.Name - назва категорії. Пробуємо знайти в БД, якщо відсутня, то створюємо нову

//                    var catname = worksheet.Name;
//                    var category = await _context.Categories.FirstOrDefaultAsync(cat => cat.Name == catname, cancellationToken);
//                    if (category == null)
//                    {
//                        category = new Category();
//                        category.Name = catname;
//                        category.Info = "from EXCEL";
//                        //додати в контекст
//                        _context.Categories.Add(category);
//                    }
//                    //перегляд усіх рядків                    
//                    foreach (var row in worksheet.RowsUsed().Skip(1))
//                    //пропустити перший рядок, бо це заголовок
//                    {
//                        await AddBookAsync(row, cancellationToken, category);
//                    }
//                }
//            }
//            await _context.SaveChangesAsync(cancellationToken);
//        }

//        private async Task AddBookAsync(IXLRow row, CancellationToken cancellationToken, Category category)
//        {
//            Book book = new Book();
//            book.Name = GetBookName(row);
//            book.Info = GetBookInfo(row);
//            book.Category = category;
//            _context.Books.Add(book);
//            await GetAuthorsAsync(row, book, cancellationToken);
//        }

//        private static string GetBookName(IXLRow row)
//        {
//            return row.Cell(1).Value.ToString();
//        }

//        private static string GetBookInfo(IXLRow row)
//        {
//            return row.Cell(6).Value.ToString();
//        }

//        private async Task GetAuthorsAsync(IXLRow row, Book book, CancellationToken cancellationToken)
//        {
//            //у разі наявності автора знайти його, у разі відсутності - додати
//            for (int i = 2; i <= 5; i++)
//            {
//                //чи є запис про автора
//                if (row.Cell(i).Value.ToString().Length > 0)
//                {
//                    var autName = row.Cell(i).Value.ToString();
//                    //перевірка чи є такий автор в базі
//                    var author = await _context.Authors.FirstOrDefaultAsync(aut => aut.Name == autName, cancellationToken);
//                    if (author is null)
//                    {
//                        author = new Author();
//                        author.Name = autName;
//                        author.Info = "from EXCEL";
//                        _context.Authors.Add(author);
//                    }

//                    AuthorBook ab = new AuthorBook();
//                    ab.Book = book;
//                    ab.Author = author;
//                    _context.AuthorBooks.Add(ab);
//                }
//            }
//        }
//    }

//}
