﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TextForum.Models
{
    public class Replies
    {
        [Key]
        public int ReplyID { get; set; }
        public int PostID { get; set; }
        public string UserName { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public string Content { get; set; }
        public string ImgUrl { get; set; }
    }
}
