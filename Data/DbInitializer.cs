using ExampleBookStore.Models;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ExampleBookStore.Data
{

    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Authors.Any())
                return;

            var authors = new Author[]{
                new Author{
                    FirstName = "Harper",
                    LastName = "Lee",
                    Books = new List<Book>{ new Book {
                                                Title = "To Kill a Mockingbird",
                                                ISBN = "0446310786",
                                                PublishDate = new DateTime(1988, 10, 11),
                                                Reviews = new List<Review>{ new Review {
                                                                                ReviewerName = "Life magazine",
                                                                                Body = "Remarkable triumph . . . Miss Lee writes with a wry compassion that makes her novel soar."
                                                                                }
                                                                            }
                                                }
                                            }
                },
                new Author{
                    FirstName = "J.R.R",
                    LastName = "Tolkien",
                    Books = new List<Book>{ new Book{
                                                Title="The Hobbit",
                                                ISBN = "054792822X",
                                                Reviews = new List<Review>{ new Review {
                                                                                ReviewerName = "The Times of London",
                                                                                Body = "A flawless masterpiece."
                                                                                }
                                                                            }
                                                }
                                            }
                },
                new Author{
                    FirstName = "John",
                    LastName = "Stienbeck",
                    Books = new List<Book>{new Book{
                                                Title = "Of Mice and Men",
                                                ISBN = "0140177396",
                                                PublishDate = new DateTime(1993, 9, 1),
                                                Reviews = new List<Review>{ new Review {
                                                                                ReviewerName = "Kirkus Reviews",
                                                                                Body = "Steinbeck refuses to allow himself to be pigeonholed...There's a simplicity, a directness, a poignancy in the story that gives it a singular power, difficult to define. Steinbeck is a genius - and an original."
                                                                                }
                                                                            }
                                                }
                                            }
                }
            };

            context.Authors.AddRange(authors);

            context.SaveChanges();
        }
    }

}