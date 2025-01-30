namespace CQRSInsurance.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; } // Başlık
        public string Content { get; set; } // İçerik
        public string Image { get; set; } // Blog görseli
        public string Category { get; set; } // Kategori (Örneğin: "İş Dünyası")
        public string Author { get; set; } // Yazar adı
        public DateTime PublishedDate { get; set; } // Yayınlanma tarihi
        public int CommentCount { get; set; } // Yorum sayısı
    }
}
