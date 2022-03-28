using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Impl
{
    public static class Storage
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();

            List<Book> books = new List<Book>()
            {
            new Book{Title = "War and peace", Pages = 200, Text="The novel begins in July 1805 in Saint Petersburg, at a soirée given by Anna Pavlovna Scherer, the maid of honour and confidante to the dowager Empress Maria Feodorovna. Many of the main characters are introduced as they enter the salon. Pierre (Pyotr Kirilovich) Bezukhov is the illegitimate son of a wealthy count, who is dying after a series of strokes. Pierre is about to become embroiled in a struggle for his inheritance. Educated abroad at his father's expense following his mother's death, Pierre is kindhearted but socially awkward, and finds it difficult to integrate into Petersburg society. It is known to everyone at the soirée that Pierre is his father's favorite of all the old count's illegitimate progeny. They respect Pierre during the soiree because his father, Count Bezukhov, is a very rich man, and as Pierre is his favorite, most aristocrats think that the fortune of his father will be given to him even though he is illegitimate.", Price=200},
            new Book{Title ="The Old Man and the Sea", Pages = 550, Text="Santiago is an aging, experienced fisherman who has gone eighty-four days without catching a fish. He is now seen as salao (colloquial pronunciation of salado, which means salty), the worst form of unlucky. Manolin, a young man whom Santiago has trained since childhood, has been forced by his parents to work on a luckier boat. Manolin remains dedicated to Santiago, visiting his shack each night, hauling his fishing gear, preparing food, and talking about American baseball and Santiago's favorite player, Joe DiMaggio. Santiago says that tomorrow, he will venture far out into the Gulf Stream, north of Cuba in the Straits of Florida to fish, confident that his unlucky streak is near its end.", Price=100},                                                                                                                                                                                                                                                       
            new Book{Title="It", Pages = 1200, Text="During a rainstorm in Derry, Maine, a six-year-old boy named Georgie Denbrough sails a paper boat along the rainy streets before it washes down into a storm drain. Looking in the drain, Georgie encounters a clown who introduces himself as Pennywise the Dancing Clown. Georgie is enticed by Pennywise to reach into the drain and retrieve his boat, where the clown rips his arm off, leaving him to die.", Price=150},                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
            new Book{Title="Three comrades", Pages = 300, Text="The city, which never is referred to by name (however, it is likely Berlin), is crowded by a growing number of jobless and marked by increasing violence between left and right. The novel starts in the seedy milieu of bars where prostitutes mingle with the hopeless flotsam that the war left behind. While Robert and his friends manage to make a living dealing cars and driving an old taxi, economic survival in the city is getting harder by the day. It is in this setting that Robert meets Patrice Hollmann, a mysterious, beautiful, young woman with an upper-middle-class background. Their love affair intensifies as he introduces her to his life of bars and races and Robert's nihilistic attitude slowly beginPrice=300,s to change as he realizes how much he needs Pat.", Price=300},                                                                                                                                                                                                   
            new Book{Title="The Picture of Dorian Grey", Pages = 720, Text="The literary merits of The Picture of Dorian Gray impressed Stoddart, but he told the publisher, George Lippincott, in its present condition there are a number of things an innocent woman would make an exception to. Fearing that the story was indecent, Stoddart deleted around five hundred words without Wilde's knowledge prior to publication. Among the pre-publication deletions were: (i) passages alluding to homosexuality and to homosexual desire; (ii) all references to the fictional book title Le Secret de Raoul and its author, Catulle Sarrazin; and (iii) all mistress references to Gray's lovers, Sibyl Vane and Hetty Merton.[5]", Price=500}                                                                                                                                                                                                                                                                                                                   
            };

            List<Author> authors = new List<Author>()
            {
            new Author{FirstName = "Lev", LastName = "Tolstoy", DateOfBirth = new DateTime(1828, 09, 9)},
            new Author{FirstName = "Ernest", LastName = "Hemingway", DateOfBirth = new DateTime(1899, 07, 21)},
            new Author{FirstName = "Stephen", LastName = "King", DateOfBirth = new DateTime(1947, 09, 21)},
            new Author{FirstName = "Erich", LastName = "Remark", DateOfBirth = new DateTime(1898, 06, 22)},
            new Author{FirstName = "Oscar", LastName = "Wilde", DateOfBirth = new DateTime(1854, 10, 16)}
            };

            List<Authors_Book> authors_books = new List<Authors_Book>()
            {
            new Authors_Book{FirstName = "Lev", LastName = "Tolstoy", AuthorId = 1, BookId = 1},
            new Authors_Book{FirstName = "Ernest", LastName = "Hemingway", AuthorId = 2, BookId = 2},
            new Authors_Book{FirstName = "Stephen", LastName = "King", AuthorId = 3, BookId = 3},
            new Authors_Book{FirstName = "Erich", LastName = "Remark", AuthorId = 4, BookId = 4},
            new Authors_Book{FirstName = "Oscar", LastName = "Wilde", AuthorId = 5, BookId = 5}
            };

            List<Chapter> chapters = new List<Chapter>()
            {
            new Chapter{Title = "The beginning of hero's life", BookId = 1},
            new Chapter{Title = "To the stars!", BookId = 2},
            new Chapter{Title = "New Life", BookId = 3},
            new Chapter{Title = "The God", BookId = 4},
            new Chapter{Title = "Adventure begins", BookId = 5}
            };

            List<Reader> readers = new List<Reader>()
            {
            new Reader{FirstName = "Dmitry", LastName = "Gordon"},
            new Reader{FirstName = "Elon", LastName = "Musk"},
            new Reader{FirstName = "Johnny", LastName = "Depp"},
            new Reader{FirstName = "Tom", LastName = "Hanks"},
            new Reader{FirstName = "Ariana", LastName = "Grande"}
            };

            List<Readers_Card> readers_cards = new List<Readers_Card>()
            {
            new Readers_Card{FirstName = "Dmitry", LastName = "Gordon", Date = new DateTime(1967, 10, 21), BookId = 1, ReaderId = 1},
            new Readers_Card{FirstName = "Elon", LastName = "Musk", Date = new DateTime(1967, 06, 28), BookId = 2, ReaderId = 2},
            new Readers_Card{FirstName = "Johnny", LastName = "Depp", Date = new DateTime(1963, 06, 09), BookId = 3, ReaderId = 3},
            new Readers_Card{FirstName = "Tom", LastName = "Hanks", Date = new DateTime(1956, 07, 09), BookId = 4, ReaderId = 4},
            new Readers_Card{FirstName = "Ariana", LastName = "Grande", Date = new DateTime(1993, 06, 26), BookId = 5, ReaderId = 5}
            };

            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Authors.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Authors_Book.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Chapters.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Readers.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Readers_Cards.Any())
            {
                return;   // DB has been seeded
            }

            foreach (var b in books)
            {
                context.Add(b);
            }

            context.SaveChanges();

            foreach (var a in authors)
            {
                context.Add(a);
            }

            context.SaveChanges();

            foreach (var ab in authors_books)
            {
                context.Add(ab);
            }

            context.SaveChanges();

            foreach (var c in chapters)
            {
                context.Add(c);
            }

            context.SaveChanges();

            foreach (var r in readers)
            {
                context.Add(r);
            }

            context.SaveChanges();

            foreach (var rc in readers_cards)
            {
                context.Add(rc);
            }

            context.SaveChanges();

            //AddEntities(builder, authors);
            //AddEntities(builder, authors_Book);
            //AddEntities(builder, Book);
            //AddEntities(builder, chapters);
            //AddEntities(builder, readers);
            //AddEntities(builder, readers_cards);
        }

        //private static void AddEntities<T>(ModelBuilder builder, List<T> entities) where T : class
        //{
        //    builder.Entity<T>().HasData(entities);
        //}
    }
}
