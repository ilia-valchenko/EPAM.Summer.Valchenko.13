﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTutorial
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual Post CommentedPost { get; set; }
        public virtual User Author { get; set; }
    }
}
