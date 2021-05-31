using BookCatalog.Domain.Entities;
using BookCatalog.Infra.Persistence.Json.Repositories;
using System;
using System.Linq;
using Xunit;

namespace BookCatalog.Tests
{
    public class JsonBookRepoTest
    {


        [Fact]
        public void AddBook()
        {

            var bookRepo = new JSonBookRepository();

            var book1 = new Book()
            {
                id = "101",
                title = "Eloquent JavaScript, Second Edition",
                author = "Marijn Haverbeke",
                isbn = "9781593275846",
                publishedDate = "2014-12-14"
            };

            Assert.True(bookRepo.AddAsync(book1).GetAwaiter().GetResult());


            //Assert.True(true);
        }

        [Fact]
        public void GetBook()
        {

            var bookRepo = new JSonBookRepository();

            var book1 = new Book()
            {
                title="Eloquent JavaScript, Second Edition",
                author="Marijn Haverbeke",
                isbn="9781593275846",
                publishedDate="2014-12-14",
                id="1"
            };

            Assert.Equal("1",bookRepo.GetById("1").GetAwaiter().GetResult().id);


            //Assert.True(true);
        }

        [Fact]
        public void GetAllBookss()
        {

            var bookRepo = new JSonBookRepository();

            var book1 = new Book()
            {
                title = "Eloquent JavaScript, Second Edition",
                author = "Marijn Haverbeke",
                isbn = "9781593275846",
                publishedDate = "2014-12-14",
                id = "1"
            };

            Assert.NotEqual(0, bookRepo.GetAll().GetAwaiter().GetResult().Count());


            //Assert.True(true);
        }
    }
}
