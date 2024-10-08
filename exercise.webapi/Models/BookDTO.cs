﻿namespace exercise.webapi.Models
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public AuthorDTO Author { get; set; }
        public int PublisherId { get; set; }
        public PublisherDTO Publisher { get; set; }
    }
}
