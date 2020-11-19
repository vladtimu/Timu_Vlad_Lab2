using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timu_Vlad_Lab2.Models.LibraryViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publishers> Publisherss { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public List<LibraryModel.Models.Publishers> Publishers { get; internal set; }
    }
}
