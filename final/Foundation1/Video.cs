class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Duration { get; set; } // in seconds
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public int GetNumberOfComments()
        {
            return Comments.Count;
        }
    }