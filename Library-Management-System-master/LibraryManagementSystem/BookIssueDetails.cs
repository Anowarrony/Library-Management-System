

using System;
using System.ComponentModel;
using System.Text;

namespace LibraryManagementSystem
{
    class BookIssueDetails
    {
        public string BookBrowwerId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }

        [DisplayName(@"Issue Date")]

        public DateTime IssueDate
        {
            get; 
            set;
        }
        
        public DateTime ReturnDate { get; set; }

  
    }
}
