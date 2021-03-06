using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Blogifier.Shared
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CommentContent { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string CommentedUserName { get; set; }
        public string CommentedUserId { get; set; }
        public bool Hidden { get; set; }
        public List<CommentsLike> CommentsLiked { get; set; }
        public int CommentDisliked { get; set; }
        public long? ParentId { get; set; }

    }
}