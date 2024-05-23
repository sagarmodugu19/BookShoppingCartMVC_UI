﻿using BookShoppingCartMVC_UI.Data;
using Microsoft.EntityFrameworkCore;

namespace BookShoppingCartMVC_UI.Repositories
{
    public class HomeRepostitory:IHomeRepository
    {
        private readonly ApplicationDbContext _db;
        public HomeRepostitory(ApplicationDbContext db)
        {

            _db = db;
        }
        public async Task<IEnumerable<Genre>>Genres()
        {
            return await _db.Genres.ToListAsync();
        }
        public async Task<IEnumerable<Book>> GetBooks(string sTerm=" ",int genreId=0)
        {
            sTerm = sTerm.ToLower();
            IEnumerable<Book> books =await (from book in _db.Books
                         join genre in _db.Genres
                         on book.GenreId equals genre.id
                         where string.IsNullOrWhiteSpace(sTerm) ||(book !=null && book.BookName.ToLower().StartsWith(sTerm))
                         select new Book
                         {
                             id = book.id,
                             Image = book.Image,
                             AuthorName = book.AuthorName,
                             BookName = book.BookName,
                             GenreId = book.GenreId,
                             Price = book.Price,
                             GenreName = genre.GenreName
                         }).ToListAsync();
           if(genreId>0)
            {
                books=books.Where(a=>a.GenreId==genreId).ToList();
            }
            return books;
        }
    }
}
