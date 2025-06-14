using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Postagens.ViewModels;

namespace Postagens.Views
{
    public partial class PostViews()
    {
        public PostViews()
        {
            InitializeComponent();
            BindingContext = new PostViewModels();
        }
    }
}
