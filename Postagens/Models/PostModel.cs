using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace Postagens.Models
{
    public class PostModel
    {
        private int userId;
        private int id;
        private string title;
        private string body;

        public int UserId { get => userId; set => userId = value; }
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Body { get => body; set => body = value; }
    }
}
