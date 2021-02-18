﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PE1
{
    public enum BugStatus {New, Closed}
    class Bug
    {
        [Key]
        public int BugId { get; set; }
        public int Type { get; set; }
        public int Description { get; set; }
        public int LastFixedDate { get; set; }
        public int AddedDate { get; set; }
        public int Status { get; set; }

        public ICollection<Fix> Fixes { get; set; }

        public int CommentId { get; set; }
        [ForeignKey("CommentId")]
        public ICollection<Comment> Comments { get; set; }

    }
}
